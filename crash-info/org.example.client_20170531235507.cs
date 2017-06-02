S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 31818
Date: 2017-05-31 23:55:07+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 31818, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00007c4a
r2   = 0x00000006, r3   = 0xb412d4c0
r4   = 0x00000002, r5   = 0xb412d000
r6   = 0xb682709c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f55708
r10  = 0xb7ea1d40, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbed40e34
lr   = 0xb671df18, pc   = 0xb671cb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     69764 KB
Buffers:     76220 KB
Cached:     275280 KB
VmPeak:     135700 KB
VmSize:     134396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29740 KB
VmRSS:       29004 KB
VmData:      46268 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35844 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 31818 TID = 31818
31818 31819 31860 31862 31893 

Maps Information
af22e000 afa2d000 rw-p [stack:31893]
b0f34000 b0f45000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f55000 b0f5a000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13ea000 b13f2000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1404000 b1c03000 rw-p [stack:31862]
b1c03000 b1c04000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c14000 b1c28000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c3c000 b1c3d000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c4d000 b1c50000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c61000 b1c62000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c72000 b1c74000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c84000 b1c86000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c96000 b1ca6000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cb6000 b1cc2000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cd4000 b24d3000 rw-p [stack:31860]
b2804000 b280b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b281e000 b2824000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2834000 b2860000 r-xp /opt/usr/apps/org.example.client/bin/client
b29b9000 b2a9c000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ad3000 b2afb000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b0d000 b330c000 rw-p [stack:31819]
b330c000 b330e000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b331e000 b3328000 r-xp /lib/libnss_files-2.20-2014.11.so
b3339000 b3342000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3353000 b3364000 r-xp /lib/libnsl-2.20-2014.11.so
b3377000 b337d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b338e000 b338f000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33b7000 b33be000 r-xp /usr/lib/libminizip.so.1.0.0
b33ce000 b33d3000 r-xp /usr/lib/libstorage.so.0.1
b33e3000 b3442000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3458000 b346c000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b347c000 b34c0000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34d0000 b34d8000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34e8000 b3518000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b352b000 b35e4000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35f8000 b364b000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b365c000 b3677000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3687000 b3748000 r-xp /usr/lib/libprotobuf.so.9.0.1
b375b000 b376b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b377b000 b3788000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3799000 b37a0000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37b0000 b37f1000 r-xp /usr/lib/libmdm.so.1.2.12
b3801000 b3809000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3818000 b3828000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3849000 b38a9000 r-xp /usr/lib/libasound.so.2.0.0
b38bb000 b38be000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38ce000 b38d1000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38e1000 b38e6000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38f6000 b38f7000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3907000 b3912000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3926000 b392d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b393d000 b3943000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3953000 b3958000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3968000 b3983000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3993000 b399a000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39aa000 b39ad000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39be000 b39ec000 r-xp /usr/lib/libidn.so.11.5.44
b39fc000 b3a12000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a23000 b3a2d000 r-xp /usr/lib/libcares.so.2.1.0
b3a3d000 b3a47000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a57000 b3a59000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a69000 b3a6a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a7a000 b3a7e000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a8f000 b3ab7000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ac8000 b3af1000 r-xp /usr/lib/libturbojpeg.so
b3b11000 b3b17000 r-xp /usr/lib/libgif.so.4.1.6
b3b27000 b3b6d000 r-xp /usr/lib/libcurl.so.4.3.0
b3b7e000 b3b9f000 r-xp /usr/lib/libexif.so.12.3.3
b3bba000 b3bcf000 r-xp /usr/lib/libtts.so
b3be0000 b3be8000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bf8000 b3cbe000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cde000 b3dd6000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3df5000 b3ec3000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eda000 b3edc000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eec000 b3ef2000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f02000 b3f25000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f36000 b3f38000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f48000 b3f4a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f5b000 b3f60000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f77000 b3f79000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f89000 b3f90000 r-xp /usr/lib/libsensord-share.so
b3fa0000 b3fb8000 r-xp /usr/lib/libsensor.so.1.1.0
b3fc9000 b3fcc000 r-xp /usr/lib/libXv.so.1.0.0
b3fdc000 b3fe1000 r-xp /usr/lib/libutilX.so.1.1.0
b3ff1000 b3ff6000 r-xp /usr/lib/libappcore-common.so.1.1
b4006000 b400d000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4020000 b4024000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4035000 b4113000 r-xp /usr/lib/libCOREGL.so.4.0
b4133000 b4136000 r-xp /usr/lib/libuuid.so.1.3.0
b4146000 b415d000 r-xp /usr/lib/libblkid.so.1.1.0
b416e000 b4170000 r-xp /usr/lib/libXau.so.6.0.0
b4180000 b41c7000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41d9000 b41df000 r-xp /usr/lib/libjson-c.so.2.0.1
b41f0000 b41f4000 r-xp /usr/lib/libogg.so.0.7.1
b4204000 b4226000 r-xp /usr/lib/libvorbis.so.0.4.3
b4236000 b431a000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4336000 b4339000 r-xp /usr/lib/libEGL.so.1.4
b434a000 b4350000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4360000 b4362000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4372000 b437f000 r-xp /usr/lib/libGLESv2.so.2.0
b4390000 b43f2000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4407000 b441f000 r-xp /usr/lib/libmount.so.1.1.0
b4431000 b4445000 r-xp /usr/lib/libxcb.so.1.1.0
b4455000 b445c000 r-xp /lib/libcrypt-2.20-2014.11.so
b4494000 b4496000 r-xp /usr/lib/libiri.so
b44a6000 b44b1000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44c2000 b44f8000 r-xp /usr/lib/libpulse.so.0.16.2
b4509000 b454c000 r-xp /usr/lib/libsndfile.so.1.0.25
b4561000 b4576000 r-xp /lib/libexpat.so.1.5.2
b4588000 b4646000 r-xp /usr/lib/libcairo.so.2.11200.14
b465a000 b4662000 r-xp /usr/lib/libdrm.so.2.4.0
b4672000 b4675000 r-xp /usr/lib/libdri2.so.0.0.0
b4685000 b46d3000 r-xp /usr/lib/libssl.so.1.0.0
b46e8000 b46f4000 r-xp /usr/lib/libeeze.so.1.13.0
b4705000 b470e000 r-xp /usr/lib/libethumb.so.1.13.0
b471e000 b4721000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4731000 b48e8000 r-xp /usr/lib/libcrypto.so.1.0.0
b56d3000 b56dc000 r-xp /usr/lib/libXi.so.6.1.0
b56ec000 b56ee000 r-xp /usr/lib/libXgesture.so.7.0.0
b56fe000 b5702000 r-xp /usr/lib/libXtst.so.6.1.0
b5712000 b5718000 r-xp /usr/lib/libXrender.so.1.3.0
b5728000 b572e000 r-xp /usr/lib/libXrandr.so.2.2.0
b573e000 b5740000 r-xp /usr/lib/libXinerama.so.1.0.0
b5751000 b5754000 r-xp /usr/lib/libXfixes.so.3.1.0
b5764000 b576f000 r-xp /usr/lib/libXext.so.6.4.0
b577f000 b5781000 r-xp /usr/lib/libXdamage.so.1.1.0
b5791000 b5793000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57a3000 b5885000 r-xp /usr/lib/libX11.so.6.3.0
b5899000 b58a0000 r-xp /usr/lib/libXcursor.so.1.0.2
b58b0000 b58c8000 r-xp /usr/lib/libudev.so.1.6.0
b58ca000 b58cd000 r-xp /lib/libattr.so.1.1.0
b58dd000 b58fd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58fe000 b5903000 r-xp /usr/lib/libffi.so.6.0.2
b5914000 b592c000 r-xp /lib/libz.so.1.2.8
b593c000 b593e000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b594e000 b5a23000 r-xp /usr/lib/libxml2.so.2.9.2
b5a38000 b5ad3000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aef000 b5af2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b02000 b5b1b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b2c000 b5b3d000 r-xp /lib/libresolv-2.20-2014.11.so
b5b51000 b5bcb000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5be0000 b5be2000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bf2000 b5bf9000 r-xp /usr/lib/libembryo.so.1.13.0
b5c09000 b5c13000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c24000 b5c3c000 r-xp /usr/lib/libpng12.so.0.50.0
b5c4d000 b5c70000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c91000 b5ca5000 r-xp /usr/lib/libector.so.1.13.0
b5cb6000 b5cce000 r-xp /usr/lib/liblua-5.1.so
b5cdf000 b5d36000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d4a000 b5d72000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d83000 b5d96000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da7000 b5de1000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df2000 b5e00000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e10000 b5e18000 r-xp /usr/lib/libtbm.so.1.0.0
b5e28000 b5e35000 r-xp /usr/lib/libeio.so.1.13.0
b5e45000 b5e47000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e57000 b5e5c000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e6c000 b5e83000 r-xp /usr/lib/libefreet.so.1.13.0
b5e95000 b5eb5000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec5000 b5ee5000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee7000 b5eed000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5efd000 b5f0e000 r-xp /usr/lib/libemotion.so.1.13.0
b5f1f000 b5f26000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f36000 b5f45000 r-xp /usr/lib/libeo.so.1.13.0
b5f56000 b5f68000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f79000 b5f7e000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f8e000 b5fa7000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb7000 b5fd4000 r-xp /usr/lib/libeet.so.1.13.0
b5fed000 b6035000 r-xp /usr/lib/libeina.so.1.13.0
b6046000 b6056000 r-xp /usr/lib/libefl.so.1.13.0
b6067000 b614c000 r-xp /usr/lib/libicuuc.so.51.1
b6169000 b62a9000 r-xp /usr/lib/libicui18n.so.51.1
b62c0000 b62f8000 r-xp /usr/lib/libecore_x.so.1.13.0
b630a000 b630d000 r-xp /lib/libcap.so.2.21
b631d000 b6346000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6357000 b635e000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6370000 b63a7000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b8000 b64a3000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b6000 b652f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6541000 b6546000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6556000 b6560000 r-xp /usr/lib/libvconf.so.0.2.45
b6570000 b6572000 r-xp /usr/lib/libvasum.so.0.3.1
b6582000 b6584000 r-xp /usr/lib/libttrace.so.1.1
b6594000 b6597000 r-xp /usr/lib/libiniparser.so.0
b65a7000 b65cd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65dd000 b65e2000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f3000 b660a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b661b000 b6686000 r-xp /lib/libm-2.20-2014.11.so
b6697000 b669d000 r-xp /lib/librt-2.20-2014.11.so
b66ae000 b66bb000 r-xp /usr/lib/libunwind.so.8.0.1
b66f1000 b6815000 r-xp /lib/libc-2.20-2014.11.so
b682a000 b6843000 r-xp /lib/libgcc_s-4.9.so.1
b6853000 b6935000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6946000 b6970000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6981000 b69bd000 r-xp /usr/lib/libsystemd.so.0.4.0
b69bf000 b6a42000 r-xp /usr/lib/libedje.so.1.13.0
b6a55000 b6a73000 r-xp /usr/lib/libecore.so.1.13.0
b6a93000 b6c1a000 r-xp /usr/lib/libevas.so.1.13.0
b6c4f000 b6c63000 r-xp /lib/libpthread-2.20-2014.11.so
b6c77000 b6eab000 r-xp /usr/lib/libelementary.so.1.13.0
b6eda000 b6ede000 r-xp /usr/lib/libsmack.so.1.0.0
b6eee000 b6ef5000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f05000 b6f07000 r-xp /usr/lib/libdlog.so.0.0.0
b6f17000 b6f1a000 r-xp /usr/lib/libbundle.so.0.1.22
b6f2a000 b6f2c000 r-xp /lib/libdl-2.20-2014.11.so
b6f3d000 b6f55000 r-xp /usr/lib/libaul.so.0.1.0
b6f69000 b6f6e000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f7f000 b6f8c000 r-xp /usr/lib/liblptcp.so
b6f9e000 b6fa2000 r-xp /usr/lib/libsys-assert.so
b6fb3000 b6fd3000 r-xp /lib/ld-2.20-2014.11.so
b6fe4000 b6fe9000 r-xp /usr/bin/launchpad-loader
b7a6b000 b7ec6000 rw-p [heap]
bed21000 bed42000 rw-p [stack]
End of Maps Information

Callstack Information (PID:31818)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb671cb84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
> send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
05-31 23:53:46.106+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(31300) status(4)
05-31 23:53:46.106+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 23:53:46.106+0900 W/AUL_AMD (  612): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
05-31 23:53:46.146+0900 I/APP_CORE(31300): appcore-efl.c: __do_app(514) > [APP 31300] Event: PAUSE State: CREATED
05-31 23:53:46.176+0900 I/TIZEN_N_EFL_UTIL_WINDOW(31300): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 32
05-31 23:53:46.216+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1806
05-31 23:53:46.226+0900 E/APP_CORE(31300): appcore-efl.c: _capture_and_make_file(1619) > win[5800002] widget[720] height[1280]
05-31 23:53:46.256+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 33
05-31 23:53:46.266+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
05-31 23:53:46.266+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 31300.
05-31 23:53:46.436+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(31300) status(0)
05-31 23:53:47.357+0900 I/UXT     (31818): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
05-31 23:53:50.120+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(31300)
05-31 23:53:50.120+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 31300, appid: org.example.client, status: bg
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
05-31 23:53:53.103+0900 W/LOCKSCREEN(  850): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
05-31 23:53:53.113+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 23:53:53.113+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
05-31 23:53:53.123+0900 E/LOCKSCREEN(  850): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
05-31 23:53:53.133+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 11:53
05-31 23:53:53.133+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 11:53"
05-31 23:53:53.133+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 11:53"
05-31 23:53:53.133+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
05-31 23:53:53.133+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145920730 Time: <font_size=31> </font_size> <font_size=31> 오후 11:53</font_size></font>"
05-31 23:53:53.133+0900 I/INDICATOR(  676): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
05-31 23:53:53.133+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
05-31 23:53:53.133+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 23:53:53.133+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 23:53:53.133+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 23:53:53.133+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 23:53:53.133+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 23:53:53.503+0900 W/LOCKSCREEN(  850): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
05-31 23:53:53.503+0900 W/LOCKSCREEN(  850): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
05-31 23:53:53.503+0900 W/APP_CORE(  850): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
05-31 23:53:53.503+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: RESUME State: PAUSED
05-31 23:53:53.503+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 23:53:53.503+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
05-31 23:53:53.503+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
05-31 23:53:53.503+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
05-31 23:53:53.503+0900 E/LOCKSCREEN(  850): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
05-31 23:53:53.503+0900 W/AUL     (  850): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
05-31 23:53:53.503+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
05-31 23:53:53.503+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 850
05-31 23:53:53.503+0900 I/AUL_AMD (  612): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
05-31 23:53:53.513+0900 W/AUL_AMD (  612): amd_launch.c: start_process(638) > child process: 31822
05-31 23:53:53.513+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 23:53:53.573+0900 W/AUL_AMD (  612): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 31822
05-31 23:53:53.573+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 31822, appid: com.samsung.weather-m-agent
05-31 23:53:53.573+0900 W/AUL     (  850): launch.c: app_request_to_launchpad(425) > request cmd(0) result(31822)
05-31 23:53:53.583+0900 I/Tizen::App( 1233): (499) > LaunchedApp(com.samsung.weather-m-agent)
05-31 23:53:53.583+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 31822.
05-31 23:53:53.714+0900 E/weather-agent(31822): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
05-31 23:53:53.724+0900 E/weather-common(31822): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
05-31 23:53:53.724+0900 E/weather-agent(31822): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
05-31 23:53:53.734+0900 I/MESSAGE_PORT(31822): message-port.c: __initialize(872) > initialize
05-31 23:53:53.744+0900 I/MESSAGE_PORT(31822): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
05-31 23:53:53.754+0900 I/Tizen::System( 1233): (280) > The screen has been turned on.
05-31 23:53:53.754+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:53:53.764+0900 W/LOCKSCREEN(  850): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
05-31 23:53:53.764+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
05-31 23:53:53.774+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
05-31 23:53:53.774+0900 I/MESSAGE_PORT(  850): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
05-31 23:53:53.774+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
05-31 23:53:53.784+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:53:53.784+0900 E/MESSAGE_PORT(31822): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
05-31 23:53:53.784+0900 I/MESSAGE_PORT( 1310): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
05-31 23:53:53.784+0900 E/MESSAGE_PORT(31822): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : 흑석동[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Heukseok-dong[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 20.000000[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 29.800000[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 65.100000[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 18[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1496238734[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
05-31 23:53:53.784+0900 E/weather-common(31822): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : On[0;m
05-31 23:53:53.784+0900 E/weather-agent(31822): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
05-31 23:53:53.784+0900 E/weather-agent(31822): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
05-31 23:53:53.784+0900 I/MESSAGE_PORT(31822): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
05-31 23:53:53.794+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:53:53.804+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:53:53.844+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
05-31 23:53:53.844+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
05-31 23:53:53.974+0900 E/EFL     (  850): ecore_x<850> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798036395
05-31 23:53:54.064+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb82801b8]
05-31 23:53:54.064+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
05-31 23:53:54.064+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb82801b8
05-31 23:53:54.064+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
05-31 23:53:54.074+0900 W/LOCATION( 1310): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
05-31 23:53:54.074+0900 E/weather-common( 1310): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
05-31 23:53:54.094+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
05-31 23:53:54.094+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_update_cb(287) > received updating signal
05-31 23:53:54.094+0900 E/EFL     ( 1310): edje<1310> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 23:53:54.124+0900 E/EFL     ( 1310): evas_main<1310> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8001bf60 is not stable during recalc loop
05-31 23:53:54.164+0900 E/EFL     ( 1310): evas_main<1310> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8001bf60 is not stable during recalc loop
05-31 23:53:54.174+0900 E/EFL     ( 1310): edje<1310> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 23:53:54.194+0900 E/cluster-home(  867): cluster-data-list.cpp: GetDBoxID(1000) >  found id[5]
05-31 23:53:54.194+0900 W/cluster-view(  867): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
05-31 23:53:54.254+0900 E/EFL     (  850): ecore_x<850> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798036673
05-31 23:53:54.254+0900 E/LOCKSCREEN(  850): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
05-31 23:53:54.254+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
05-31 23:53:54.254+0900 E/LOCKSCREEN(  850): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
05-31 23:53:54.584+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
05-31 23:53:54.584+0900 W/LOCKSCREEN(  850): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
05-31 23:53:54.584+0900 W/LOCKSCREEN(  850): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
05-31 23:53:54.594+0900 E/LOCKSCREEN(  850): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
05-31 23:53:54.594+0900 E/LOCKSCREEN(  850): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
05-31 23:53:54.594+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 23:53:54.594+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
05-31 23:53:54.594+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
05-31 23:53:54.594+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
05-31 23:53:54.614+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 23:53:54.614+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(850) status(4)
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
05-31 23:53:54.614+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(850)
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
05-31 23:53:54.614+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 850, appid: com.samsung.lockscreen, status: bg
05-31 23:53:54.614+0900 E/LOCKSCREEN(  850): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
05-31 23:53:54.614+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: PAUSE State: RUNNING
05-31 23:53:54.614+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
05-31 23:53:54.614+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 23:53:54.614+0900 E/LOCKSCREEN(  850): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
05-31 23:53:54.614+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
05-31 23:53:54.614+0900 E/LOCKSCREEN(  850): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
05-31 23:53:54.624+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 23:53:54.624+0900 I/APP_CORE(31300): appcore-efl.c: __do_app(514) > [APP 31300] Event: RESUME State: CREATED
05-31 23:53:54.644+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(31300) status(3)
05-31 23:53:54.644+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 23:53:54.644+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 23:53:54.644+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(31300)
05-31 23:53:54.644+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 31300, appid: org.example.client, status: fg
05-31 23:53:54.654+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
05-31 23:53:54.664+0900 I/APP_CORE(31300): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
05-31 23:53:54.664+0900 I/APP_CORE(31300): appcore-efl.c: __do_app(625) > [APP 31300] Initial Launching, call the resume_cb
05-31 23:53:54.664+0900 I/CAPI_APPFW_APPLICATION(31300): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 23:53:54.674+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
05-31 23:53:54.674+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:53:54.674+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:53:54.684+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:53:54.725+0900 W/LOCKSCREEN(  850): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
05-31 23:53:54.725+0900 E/LOCKSCREEN(  850): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
05-31 23:53:54.725+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 23:53:54.725+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
05-31 23:53:54.725+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
05-31 23:53:54.725+0900 E/LOCKSCREEN(  850): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
05-31 23:53:54.795+0900 E/weather-agent(31822): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
05-31 23:53:54.795+0900 I/CAPI_APPFW_APPLICATION(31822): service_app_main.c: service_app_exit(446) > service_app_exit
05-31 23:53:54.795+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 22
05-31 23:53:54.795+0900 E/weather-agent(31822): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
05-31 23:53:54.795+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(1201) > app status : 5
05-31 23:53:54.915+0900 W/AUL_AMD (  612): amd_request.c: __send_app_termination_signal(609) > send dead signal done
05-31 23:53:54.925+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 31822
05-31 23:53:54.925+0900 I/Tizen::App( 1233): (243) > App[com.samsung.weather-m-agent] pid[31822] terminate event is forwarded
05-31 23:53:54.925+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
05-31 23:53:54.925+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 31822, ]
05-31 23:53:54.925+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
05-31 23:53:54.925+0900 I/Tizen::App( 1233): (506) > TerminatedApp(com.samsung.weather-m-agent)
05-31 23:53:54.925+0900 I/Tizen::App( 1233): (512) > Not registered pid(31822)
05-31 23:53:54.925+0900 I/Tizen::System( 1233): (246) > Terminated app [com.samsung.weather-m-agent]
05-31 23:53:54.925+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:53:54.925+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 31822
05-31 23:53:54.925+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:53:54.925+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 31822.
05-31 23:53:56.306+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798038727
05-31 23:53:56.316+0900 I/MY_LOG  (31300): Button pressed
05-31 23:53:56.406+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798038815
05-31 23:53:56.406+0900 E/VCONF   (31300): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
05-31 23:53:56.406+0900 E/VCONF   (31300): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
05-31 23:53:56.406+0900 E/VCONF   (31300): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
05-31 23:53:56.406+0900 E/VCONF   (31300): vconf.c: vconf_get_bool(2729) > vconf_get_bool(31300) : db/ise/keysound error
05-31 23:53:56.416+0900 E/VCONF   (31300): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
05-31 23:53:56.416+0900 E/VCONF   (31300): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
05-31 23:53:56.466+0900 I/MY_LOG  (31300): Button unpressed
05-31 23:53:57.097+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798039516
05-31 23:53:57.097+0900 I/MY_LOG  (31300): Button pressed
05-31 23:53:57.187+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798039605
05-31 23:53:57.187+0900 I/MY_LOG  (31300): Button unpressed
05-31 23:53:57.227+0900 D/basicui (31300): successed to load edc file
05-31 23:53:57.307+0900 I/MY_LOG  (31300): change
05-31 23:53:57.467+0900 I/MY_LOG  (31300): change
05-31 23:53:59.079+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798041497
05-31 23:53:59.089+0900 I/MY_LOG  (31300): Button pressed
05-31 23:53:59.179+0900 E/EFL     (31300): ecore_x<31300> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798041597
05-31 23:53:59.179+0900 I/MY_LOG  (31300): Button unpressed
05-31 23:53:59.189+0900 I/basicui (31300): (selected item : DEFAULT)
05-31 23:53:59.619+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
05-31 23:53:59.799+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
05-31 23:54:00.130+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
05-31 23:54:00.130+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 11:54
05-31 23:54:00.130+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 11:54"
05-31 23:54:00.130+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 11:54"
05-31 23:54:00.130+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
05-31 23:54:00.130+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145897656 Time: <font_size=31> </font_size> <font_size=31> 오후 11:54</font_size></font>"
05-31 23:54:35.314+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 23:54:35.314+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
05-31 23:54:35.324+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 23:54:35.324+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 23:54:35.324+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
05-31 23:54:35.324+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
05-31 23:54:35.344+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 31300 pgid = 31300
05-31 23:54:35.344+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(31300)
05-31 23:54:35.354+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
05-31 23:54:35.384+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
05-31 23:54:35.384+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 23:54:35.384+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
05-31 23:54:35.384+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 23:54:35.404+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
05-31 23:54:35.414+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
05-31 23:54:35.414+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
05-31 23:54:35.414+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
05-31 23:54:35.414+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 31300
05-31 23:54:35.424+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 31300
05-31 23:54:35.424+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 31300
05-31 23:54:35.434+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
05-31 23:54:35.444+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
05-31 23:54:35.444+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:54:35.444+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1812
05-31 23:54:35.454+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
05-31 23:54:35.454+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 23:54:35.454+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
05-31 23:54:35.454+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 23:54:35.474+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:54:35.474+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[31300] terminate event is forwarded
05-31 23:54:35.474+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
05-31 23:54:35.474+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 31300, ]
05-31 23:54:35.474+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
05-31 23:54:35.474+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
05-31 23:54:35.474+0900 I/Tizen::App( 1233): (512) > Not registered pid(31300)
05-31 23:54:35.474+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
05-31 23:54:35.474+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:54:35.474+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:54:35.494+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:54:35.494+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 31300.
05-31 23:54:35.504+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
05-31 23:54:35.534+0900 W/CRASH_MANAGER(31837): worker.c: worker_job(1199) > 0631300636c691496242475
05-31 23:54:35.564+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb8228568]
05-31 23:54:35.564+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
05-31 23:54:35.564+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb8228568
05-31 23:54:35.564+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
05-31 23:54:35.574+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
05-31 23:54:35.574+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
05-31 23:54:35.574+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
05-31 23:54:35.574+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
05-31 23:54:39.258+0900 E/EFL     (  867): ecore_x<867> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798081677
05-31 23:54:39.358+0900 E/EFL     (  867): ecore_x<867> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798081777
05-31 23:54:39.368+0900 W/AUL     (  867): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
05-31 23:54:39.368+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 1
05-31 23:54:39.368+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 867
05-31 23:54:39.378+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
05-31 23:54:39.378+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 23:54:39.378+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
05-31 23:54:39.378+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
05-31 23:54:39.378+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
05-31 23:54:39.398+0900 I/abc     (31818): abc
05-31 23:54:39.398+0900 I/CAPI_APPFW_APPLICATION(31818): app_main.c: ui_app_main(789) > app_efl_main
05-31 23:54:39.398+0900 I/CAPI_APPFW_APPLICATION(31818): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
05-31 23:54:39.428+0900 E/TBM     (31818): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
05-31 23:54:39.478+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 31818, appid: org.example.client
05-31 23:54:39.488+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
05-31 23:54:39.488+0900 W/AUL     (  867): launch.c: app_request_to_launchpad(425) > request cmd(1) result(31818)
05-31 23:54:39.748+0900 I/APP_CORE(31818): appcore-efl.c: __do_app(514) > [APP 31818] Event: RESET State: CREATED
05-31 23:54:39.748+0900 I/CAPI_APPFW_APPLICATION(31818): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
05-31 23:54:39.758+0900 E/EFL     (31818): edje<31818> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 23:54:39.758+0900 E/EFL     (31818): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 23:54:39.768+0900 E/EFL     (31818): edje<31818> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 23:54:39.768+0900 E/EFL     (31818): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 23:54:39.768+0900 E/EFL     (31818): edje<31818> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 23:54:39.768+0900 E/EFL     (31818): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 23:54:39.778+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 23:54:39.778+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 23:54:39.799+0900 W/APP_CORE(31818): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-31 23:54:39.799+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
05-31 23:54:39.809+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 23:54:39.819+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
05-31 23:54:39.819+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 23:54:39.819+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 23:54:39.909+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
05-31 23:54:39.909+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
05-31 23:54:39.909+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
05-31 23:54:39.919+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
05-31 23:54:39.919+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
05-31 23:54:39.919+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
05-31 23:54:39.919+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(31818) status(3)
05-31 23:54:39.919+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(31818)
05-31 23:54:39.919+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 31818, appid: org.example.client, status: fg
05-31 23:54:39.929+0900 I/APP_CORE(31818): appcore-efl.c: __do_app(514) > [APP 31818] Event: RESUME State: CREATED
05-31 23:54:39.929+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
05-31 23:54:39.929+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
05-31 23:54:39.929+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
05-31 23:54:39.939+0900 I/APP_CORE(31818): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
05-31 23:54:39.939+0900 I/APP_CORE(31818): appcore-efl.c: __do_app(625) > [APP 31818] Initial Launching, call the resume_cb
05-31 23:54:39.939+0900 I/CAPI_APPFW_APPLICATION(31818): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 23:54:40.269+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(31818) status(0)
05-31 23:54:40.509+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1814
05-31 23:54:40.509+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
05-31 23:54:40.509+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 31818.
05-31 23:54:41.300+0900 I/UXT     (31870): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
05-31 23:54:42.932+0900 E/EFL     (31818): ecore_x<31818> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798085350
05-31 23:54:42.932+0900 I/MY_LOG  (31818): Button pressed
05-31 23:54:43.032+0900 E/EFL     (31818): ecore_x<31818> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798085449
05-31 23:54:43.032+0900 E/VCONF   (31818): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
05-31 23:54:43.032+0900 E/VCONF   (31818): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
05-31 23:54:43.032+0900 E/VCONF   (31818): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
05-31 23:54:43.032+0900 E/VCONF   (31818): vconf.c: vconf_get_bool(2729) > vconf_get_bool(31818) : db/ise/keysound error
05-31 23:54:43.042+0900 E/VCONF   (31818): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
05-31 23:54:43.042+0900 E/VCONF   (31818): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
05-31 23:54:43.082+0900 I/MY_LOG  (31818): Button unpressed
05-31 23:54:43.122+0900 D/basicui (31818): successed to load edc file
05-31 23:54:43.192+0900 I/MY_LOG  (31818): change
05-31 23:54:44.453+0900 E/EFL     (31818): ecore_x<31818> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798086866
05-31 23:54:44.453+0900 I/MY_LOG  (31818): Button pressed
05-31 23:54:44.583+0900 E/EFL     (31818): ecore_x<31818> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798086999
05-31 23:54:44.583+0900 I/MY_LOG  (31818): Button unpressed
05-31 23:54:44.603+0900 E/EFL     (31818): elementary<31818> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
05-31 23:54:44.913+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: MEM_FLUSH State: PAUSED
05-31 23:54:45.344+0900 E/EFL     (31818): ecore_x<31818> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798087759
05-31 23:54:45.344+0900 I/MY_LOG  (31818): Button pressed
05-31 23:54:45.414+0900 E/EFL     (31818): ecore_x<31818> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798087836
05-31 23:54:45.424+0900 I/MY_LOG  (31818): Button unpressed
05-31 23:54:46.025+0900 E/EFL     (31818): ecore_x<31818> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798088445
05-31 23:54:46.025+0900 I/MY_LOG  (31818): Button pressed
05-31 23:54:46.115+0900 E/EFL     (31818): ecore_x<31818> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798088533
05-31 23:54:46.115+0900 I/MY_LOG  (31818): Button unpressed
05-31 23:54:46.145+0900 D/basicui (31818): successed to load edc file
05-31 23:54:46.175+0900 I/MY_LOG  (31818): change
05-31 23:54:46.335+0900 I/MY_LOG  (31818): change
05-31 23:54:47.156+0900 E/EFL     (31818): ecore_x<31818> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=798089578
05-31 23:54:47.166+0900 I/MY_LOG  (31818): Button pressed
05-31 23:54:47.266+0900 E/EFL     (31818): ecore_x<31818> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=798089689
05-31 23:54:47.276+0900 I/MY_LOG  (31818): Button unpressed
05-31 23:54:47.276+0900 I/basicui (31818): (selected item : DEFAULT)
05-31 23:55:00.138+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
05-31 23:55:00.148+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 11:55
05-31 23:55:00.148+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오후 11:55"
05-31 23:55:00.148+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 11:55"
05-31 23:55:00.148+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
05-31 23:55:00.148+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145916565 Time: <font_size=31> </font_size> <font_size=31> 오후 11:55</font_size></font>"
05-31 23:55:07.636+0900 W/CRASH_MANAGER(31837): worker.c: worker_job(1199) > 0631818636c69149624250
