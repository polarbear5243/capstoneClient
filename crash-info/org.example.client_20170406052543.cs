S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 11662
Date: 2017-04-06 05:25:43+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 11662, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002d8e
r2   = 0x00000006, r3   = 0xb40da4c0
r4   = 0x00000002, r5   = 0xb40da000
r6   = 0xb67d409c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f02708
r10  = 0xb77f9560, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbeb1cc2c
lr   = 0xb66caf18, pc   = 0xb66c9b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     72184 KB
Buffers:     63072 KB
Cached:     290372 KB
VmPeak:     133920 KB
VmSize:     133916 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28348 KB
VmRSS:       28348 KB
VmData:      45860 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35780 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 11662 TID = 11662
11662 11663 12269 12274 12278 

Maps Information
aee8e000 af68d000 rw-p [stack:12278]
b0f80000 b0f91000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0fa1000 b0fa6000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13a8000 b13b0000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13c2000 b1bc1000 rw-p [stack:12274]
b1bc1000 b1bc2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bd2000 b1be6000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bfa000 b1bfb000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c0b000 b1c0e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c1f000 b1c20000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c30000 b1c32000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c42000 b1c44000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c54000 b1c64000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c74000 b1c80000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c92000 b2491000 rw-p [stack:12269]
b27c2000 b27c9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27dc000 b27e2000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27f2000 b280e000 r-xp /opt/usr/apps/org.example.client/bin/client
b2966000 b2a49000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a80000 b2aa8000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aba000 b32b9000 rw-p [stack:11663]
b32b9000 b32bb000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32cb000 b32d5000 r-xp /lib/libnss_files-2.20-2014.11.so
b32e6000 b32ef000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3300000 b3311000 r-xp /lib/libnsl-2.20-2014.11.so
b3324000 b332a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b333b000 b333c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3364000 b336b000 r-xp /usr/lib/libminizip.so.1.0.0
b337b000 b3380000 r-xp /usr/lib/libstorage.so.0.1
b3390000 b33ef000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3405000 b3419000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3429000 b346d000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b347d000 b3485000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3495000 b34c5000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34d8000 b3591000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35a5000 b35f8000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3609000 b3624000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3634000 b36f5000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3708000 b3718000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3728000 b3735000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3746000 b374d000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b375d000 b379e000 r-xp /usr/lib/libmdm.so.1.2.12
b37ae000 b37b6000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37c5000 b37d5000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37f6000 b3856000 r-xp /usr/lib/libasound.so.2.0.0
b3868000 b386b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b387b000 b387e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b388e000 b3893000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38a3000 b38a4000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38b4000 b38bf000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38d3000 b38da000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38ea000 b38f0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3900000 b3905000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3915000 b3930000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3940000 b3947000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3957000 b395a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b396b000 b3999000 r-xp /usr/lib/libidn.so.11.5.44
b39a9000 b39bf000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39d0000 b39da000 r-xp /usr/lib/libcares.so.2.1.0
b39ea000 b39f4000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a04000 b3a06000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a16000 b3a17000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a27000 b3a2b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a3c000 b3a64000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a75000 b3a9e000 r-xp /usr/lib/libturbojpeg.so
b3abe000 b3ac4000 r-xp /usr/lib/libgif.so.4.1.6
b3ad4000 b3b1a000 r-xp /usr/lib/libcurl.so.4.3.0
b3b2b000 b3b4c000 r-xp /usr/lib/libexif.so.12.3.3
b3b67000 b3b7c000 r-xp /usr/lib/libtts.so
b3b8d000 b3b95000 r-xp /usr/lib/libfeedback.so.0.1.4
b3ba5000 b3c6b000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c8b000 b3d83000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3da2000 b3e70000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e87000 b3e89000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e99000 b3e9f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eaf000 b3ed2000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ee3000 b3ee5000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ef5000 b3ef7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f08000 b3f0d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f24000 b3f26000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f36000 b3f3d000 r-xp /usr/lib/libsensord-share.so
b3f4d000 b3f65000 r-xp /usr/lib/libsensor.so.1.1.0
b3f76000 b3f79000 r-xp /usr/lib/libXv.so.1.0.0
b3f89000 b3f8e000 r-xp /usr/lib/libutilX.so.1.1.0
b3f9e000 b3fa3000 r-xp /usr/lib/libappcore-common.so.1.1
b3fb3000 b3fba000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fcd000 b3fd1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fe2000 b40c0000 r-xp /usr/lib/libCOREGL.so.4.0
b40e0000 b40e3000 r-xp /usr/lib/libuuid.so.1.3.0
b40f3000 b410a000 r-xp /usr/lib/libblkid.so.1.1.0
b411b000 b411d000 r-xp /usr/lib/libXau.so.6.0.0
b412d000 b4174000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4186000 b418c000 r-xp /usr/lib/libjson-c.so.2.0.1
b419d000 b41a1000 r-xp /usr/lib/libogg.so.0.7.1
b41b1000 b41d3000 r-xp /usr/lib/libvorbis.so.0.4.3
b41e3000 b42c7000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42e3000 b42e6000 r-xp /usr/lib/libEGL.so.1.4
b42f7000 b42fd000 r-xp /usr/lib/libxcb-render.so.0.0.0
b430d000 b430f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b431f000 b432c000 r-xp /usr/lib/libGLESv2.so.2.0
b433d000 b439f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43b4000 b43cc000 r-xp /usr/lib/libmount.so.1.1.0
b43de000 b43f2000 r-xp /usr/lib/libxcb.so.1.1.0
b4402000 b4409000 r-xp /lib/libcrypt-2.20-2014.11.so
b4441000 b4443000 r-xp /usr/lib/libiri.so
b4453000 b445e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b446f000 b44a5000 r-xp /usr/lib/libpulse.so.0.16.2
b44b6000 b44f9000 r-xp /usr/lib/libsndfile.so.1.0.25
b450e000 b4523000 r-xp /lib/libexpat.so.1.5.2
b4535000 b45f3000 r-xp /usr/lib/libcairo.so.2.11200.14
b4607000 b460f000 r-xp /usr/lib/libdrm.so.2.4.0
b461f000 b4622000 r-xp /usr/lib/libdri2.so.0.0.0
b4632000 b4680000 r-xp /usr/lib/libssl.so.1.0.0
b4695000 b46a1000 r-xp /usr/lib/libeeze.so.1.13.0
b46b2000 b46bb000 r-xp /usr/lib/libethumb.so.1.13.0
b46cb000 b46ce000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46de000 b4895000 r-xp /usr/lib/libcrypto.so.1.0.0
b5680000 b5689000 r-xp /usr/lib/libXi.so.6.1.0
b5699000 b569b000 r-xp /usr/lib/libXgesture.so.7.0.0
b56ab000 b56af000 r-xp /usr/lib/libXtst.so.6.1.0
b56bf000 b56c5000 r-xp /usr/lib/libXrender.so.1.3.0
b56d5000 b56db000 r-xp /usr/lib/libXrandr.so.2.2.0
b56eb000 b56ed000 r-xp /usr/lib/libXinerama.so.1.0.0
b56fe000 b5701000 r-xp /usr/lib/libXfixes.so.3.1.0
b5711000 b571c000 r-xp /usr/lib/libXext.so.6.4.0
b572c000 b572e000 r-xp /usr/lib/libXdamage.so.1.1.0
b573e000 b5740000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5750000 b5832000 r-xp /usr/lib/libX11.so.6.3.0
b5846000 b584d000 r-xp /usr/lib/libXcursor.so.1.0.2
b585d000 b5875000 r-xp /usr/lib/libudev.so.1.6.0
b5877000 b587a000 r-xp /lib/libattr.so.1.1.0
b588a000 b58aa000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ab000 b58b0000 r-xp /usr/lib/libffi.so.6.0.2
b58c1000 b58d9000 r-xp /lib/libz.so.1.2.8
b58e9000 b58eb000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58fb000 b59d0000 r-xp /usr/lib/libxml2.so.2.9.2
b59e5000 b5a80000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a9c000 b5a9f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aaf000 b5ac8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad9000 b5aea000 r-xp /lib/libresolv-2.20-2014.11.so
b5afe000 b5b78000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b8d000 b5b8f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b9f000 b5ba6000 r-xp /usr/lib/libembryo.so.1.13.0
b5bb6000 b5bc0000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bd1000 b5be9000 r-xp /usr/lib/libpng12.so.0.50.0
b5bfa000 b5c1d000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c3e000 b5c52000 r-xp /usr/lib/libector.so.1.13.0
b5c63000 b5c7b000 r-xp /usr/lib/liblua-5.1.so
b5c8c000 b5ce3000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf7000 b5d1f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d30000 b5d43000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d54000 b5d8e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d9f000 b5dad000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dbd000 b5dc5000 r-xp /usr/lib/libtbm.so.1.0.0
b5dd5000 b5de2000 r-xp /usr/lib/libeio.so.1.13.0
b5df2000 b5df4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e04000 b5e09000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e19000 b5e30000 r-xp /usr/lib/libefreet.so.1.13.0
b5e42000 b5e62000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e72000 b5e92000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e94000 b5e9a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eaa000 b5ebb000 r-xp /usr/lib/libemotion.so.1.13.0
b5ecc000 b5ed3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ee3000 b5ef2000 r-xp /usr/lib/libeo.so.1.13.0
b5f03000 b5f15000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f26000 b5f2b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f3b000 b5f54000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f64000 b5f81000 r-xp /usr/lib/libeet.so.1.13.0
b5f9a000 b5fe2000 r-xp /usr/lib/libeina.so.1.13.0
b5ff3000 b6003000 r-xp /usr/lib/libefl.so.1.13.0
b6014000 b60f9000 r-xp /usr/lib/libicuuc.so.51.1
b6116000 b6256000 r-xp /usr/lib/libicui18n.so.51.1
b626d000 b62a5000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b7000 b62ba000 r-xp /lib/libcap.so.2.21
b62ca000 b62f3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6304000 b630b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b631d000 b6354000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6365000 b6450000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6463000 b64dc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ee000 b64f3000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6503000 b650d000 r-xp /usr/lib/libvconf.so.0.2.45
b651d000 b651f000 r-xp /usr/lib/libvasum.so.0.3.1
b652f000 b6531000 r-xp /usr/lib/libttrace.so.1.1
b6541000 b6544000 r-xp /usr/lib/libiniparser.so.0
b6554000 b657a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b658a000 b658f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65a0000 b65b7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c8000 b6633000 r-xp /lib/libm-2.20-2014.11.so
b6644000 b664a000 r-xp /lib/librt-2.20-2014.11.so
b665b000 b6668000 r-xp /usr/lib/libunwind.so.8.0.1
b669e000 b67c2000 r-xp /lib/libc-2.20-2014.11.so
b67d7000 b67f0000 r-xp /lib/libgcc_s-4.9.so.1
b6800000 b68e2000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68f3000 b691d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b692e000 b696a000 r-xp /usr/lib/libsystemd.so.0.4.0
b696c000 b69ef000 r-xp /usr/lib/libedje.so.1.13.0
b6a02000 b6a20000 r-xp /usr/lib/libecore.so.1.13.0
b6a40000 b6bc7000 r-xp /usr/lib/libevas.so.1.13.0
b6bfc000 b6c10000 r-xp /lib/libpthread-2.20-2014.11.so
b6c24000 b6e58000 r-xp /usr/lib/libelementary.so.1.13.0
b6e87000 b6e8b000 r-xp /usr/lib/libsmack.so.1.0.0
b6e9b000 b6ea2000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eb2000 b6eb4000 r-xp /usr/lib/libdlog.so.0.0.0
b6ec4000 b6ec7000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed7000 b6ed9000 r-xp /lib/libdl-2.20-2014.11.so
b6eea000 b6f02000 r-xp /usr/lib/libaul.so.0.1.0
b6f16000 b6f1b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f2c000 b6f39000 r-xp /usr/lib/liblptcp.so
b6f4b000 b6f4f000 r-xp /usr/lib/libsys-assert.so
b6f60000 b6f80000 r-xp /lib/ld-2.20-2014.11.so
b6f91000 b6f96000 r-xp /usr/bin/launchpad-loader
b7476000 b7855000 rw-p [heap]
beafd000 beb1e000 rw-p [stack]
beafd000 beb1e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11662)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66c9b84) [/lib/libc.so.6] + 0x2bb84
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
0962) status(3)
04-06 05:23:17.974+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:23:17.974+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:23:17.974+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(10962)
04-06 05:23:17.974+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10962, appid: com.samsung.task-mgr, status: fg
04-06 05:23:17.974+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-06 05:23:17.974+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-06 05:23:17.974+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-06 05:23:17.974+0900 E/STARTER (  709): )
04-06 05:23:17.984+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-06 05:23:17.984+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-06 05:23:17.984+0900 E/VOLUME  (  854): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-06 05:23:17.984+0900 E/VOLUME  (  854): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-06 05:23:17.984+0900 I/APP_CORE(10962): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:23:17.984+0900 I/APP_CORE(10962): appcore-efl.c: __do_app(625) > [APP 10962] Initial Launching, call the resume_cb
04-06 05:23:17.984+0900 I/CAPI_APPFW_APPLICATION(10962): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:23:18.354+0900 E/EFL     (10962): ecore_x<10962> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=221717724
04-06 05:23:18.444+0900 E/EFL     (10962): ecore_x<10962> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=221717813
04-06 05:23:18.494+0900 E/EFL     (10899): ecore_x<10899> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=221716515
04-06 05:23:18.494+0900 E/EFL     (10899): ecore_x<10899> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=221717313
04-06 05:23:18.494+0900 I/APP_CORE(10899): appcore-efl.c: __do_app(514) > [APP 10899] Event: PAUSE State: RUNNING
04-06 05:23:18.494+0900 I/CAPI_APPFW_APPLICATION(10899): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:23:18.504+0900 I/TIZEN_N_EFL_UTIL_WINDOW(10899): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 9
04-06 05:23:18.504+0900 E/APP_CORE(10899): appcore-efl.c: _capture_and_make_file(1619) > win[7200002] widget[720] height[1280]
04-06 05:23:18.504+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 05:23:18.624+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2182
04-06 05:23:18.624+0900 I/Tizen::App( 1231): (499) > LaunchedApp(com.samsung.task-mgr)
04-06 05:23:18.624+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for com.samsung.task-mgr, 10962.
04-06 05:23:18.965+0900 E/EFL     (10962): ecore_x<10962> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=221718329
04-06 05:23:19.035+0900 E/EFL     (10962): ecore_x<10962> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=221718406
04-06 05:23:19.365+0900 I/UXT     (12007): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:23:19.405+0900 E/TBM     (12007): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:23:19.405+0900 I/MALI    (12007): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=12007   open drm_fd=30 
04-06 05:23:19.525+0900 E/EFL     (12007): edje<12007> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:23:19.525+0900 E/EFL     (12007): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:23:19.525+0900 E/EFL     (12007): edje<12007> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:23:19.525+0900 E/EFL     (12007): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:23:19.525+0900 E/EFL     (12007): edje<12007> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:23:19.525+0900 E/EFL     (12007): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:23:19.585+0900 E/EFL     (10962): ecore_x<10962> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=221718956
04-06 05:23:19.725+0900 E/EFL     (10962): ecore_x<10962> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=221719089
04-06 05:23:20.236+0900 E/EFL     (10962): ecore_x<10962> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=221719595
04-06 05:23:20.316+0900 E/EFL     (10962): ecore_x<10962> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=221719683
04-06 05:23:20.626+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:23:20.626+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:23:20.626+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(10962)
04-06 05:23:20.626+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10962, appid: com.samsung.task-mgr, status: bg
04-06 05:23:20.636+0900 I/CAPI_APPFW_APPLICATION(10962): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:23:20.636+0900 W/TASK_MGR_LITE(10962): task-mgr-lite.c: _pause_app(406) > 
04-06 05:23:20.636+0900 I/CAPI_APPFW_APPLICATION(10962): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 05:23:20.636+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:23:20.636+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 10899
04-06 05:23:20.636+0900 W/AUL     (10962): launch.c: app_request_to_launchpad(396) > request cmd(4) to(10899)
04-06 05:23:20.636+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 4
04-06 05:23:20.646+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(10899), cmd(4)
04-06 05:23:20.646+0900 I/APP_CORE(10899): appcore-efl.c: __do_app(514) > [APP 10899] Event: TERMINATE State: PAUSED
04-06 05:23:20.646+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:23:20.646+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:23:20.646+0900 W/AUL     (10962): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
04-06 05:23:20.646+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-06 05:23:20.646+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-06 05:23:20.656+0900 E/TASK_MGR_LITE(10962): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
04-06 05:23:20.666+0900 I/TIZEN_N_EFL_UTIL_WINDOW(10899): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 19
04-06 05:23:20.666+0900 E/APP_CORE(10899): appcore-efl.c: _capture_and_make_file(1619) > win[7200002] widget[720] height[1280]
04-06 05:23:20.676+0900 E/TASK_MGR_LITE(10962): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
04-06 05:23:20.686+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-06 05:23:20.686+0900 E/APP_CORE(10899): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-06 05:23:20.686+0900 I/CAPI_APPFW_APPLICATION(10899): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-06 05:23:20.706+0900 E/APP_CORE(10962): appcore.c: appcore_flush_memory(793) > Appcore not initialized
04-06 05:23:20.706+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:23:20.716+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:23:20.716+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:23:20.716+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:23:20.716+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:23:20.716+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:23:20.756+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:23:20.787+0900 I/MALI    (10962): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=10962   close drm_fd=30 
04-06 05:23:20.797+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:23:20.797+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 05:23:20.797+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:23:20.797+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 05:23:20.837+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 05:23:20.857+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 05:23:20.857+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [com.samsun] 
04-06 05:23:20.857+0900 I/Tizen::System( 1231): (273) > Current App[com.samsun] is already actived.
04-06 05:23:20.877+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:23:20.877+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 05:23:20.897+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b91508]
04-06 05:23:20.897+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 05:23:20.897+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b91508
04-06 05:23:20.897+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 05:23:20.907+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 05:23:20.907+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 05:23:20.907+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 05:23:20.907+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 05:23:21.057+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: MEM_FLUSH State: PAUSED
04-06 05:23:21.117+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10962 pgid = 10962
04-06 05:23:21.117+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(10962)
04-06 05:23:21.147+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:23:21.147+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:23:21.147+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:23:21.157+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 10962
04-06 05:23:21.157+0900 I/Tizen::App( 1231): (243) > App[com.samsung.task-mgr] pid[10962] terminate event is forwarded
04-06 05:23:21.157+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10962
04-06 05:23:21.157+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:23:21.157+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 10962
04-06 05:23:21.157+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [com.samsung.task-mgr, 10962, ]
04-06 05:23:21.157+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:23:21.157+0900 I/Tizen::App( 1231): (506) > TerminatedApp(com.samsung.task-mgr)
04-06 05:23:21.157+0900 I/Tizen::App( 1231): (512) > Not registered pid(10962)
04-06 05:23:21.157+0900 I/Tizen::System( 1231): (246) > Terminated app [com.samsung.task-mgr]
04-06 05:23:21.157+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:23:21.157+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2185
04-06 05:23:21.167+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:23:21.167+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for com.samsung.task-mgr, 10962.
04-06 05:23:21.207+0900 E/VCONF   (10899): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/opt/var/kdb/db/ise+keysound]: Permission denied
04-06 05:23:21.207+0900 E/VCONF   (10899): vconf.c: vconf_ignore_key_changed(3218) > vconf_ignore_key_changed() failed: key(db/ise/keysound)
04-06 05:23:21.247+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10899 pgid = 10899
04-06 05:23:21.247+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(10899)
04-06 05:23:21.267+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 05:23:21.267+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 05:23:21.267+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 05:23:21.267+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 10899
04-06 05:23:21.267+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[10899] terminate event is forwarded
04-06 05:23:21.267+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 05:23:21.267+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 10899, ]
04-06 05:23:21.267+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 05:23:21.267+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 05:23:21.267+0900 I/Tizen::App( 1231): (512) > Not registered pid(10899)
04-06 05:23:21.267+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 05:23:21.267+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:23:21.267+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10899
04-06 05:23:21.267+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2186
04-06 05:23:21.277+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:23:21.277+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 10899.
04-06 05:23:21.727+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:23:25.641+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:23:25.651+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:23:25.651+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 05:23:28.564+0900 E/AUL_AMD (  610): amd_launch.c: _amd_proc_find_proc_info(1914) > proc info not found
04-06 05:24:00.155+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:24:00.155+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:24
04-06 05:24:00.155+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 5:24"
04-06 05:24:00.155+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:24"
04-06 05:24:00.155+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:24:00.155+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146532824 Time: <font_size=31> </font_size> <font_size=31> 오전 5:24</font_size></font>"
04-06 05:25:00.224+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 05:25:00.224+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 5:25
04-06 05:25:00.224+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 5:25"
04-06 05:25:00.224+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 5:25"
04-06 05:25:00.224+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 05:25:00.224+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146530260 Time: <font_size=31> </font_size> <font_size=31> 오전 5:25</font_size></font>"
04-06 05:25:24.097+0900 E/PKGMGR_SERVER(12063): pkgmgr-server.c: main(2414) > package manager server start
04-06 05:25:24.147+0900 E/PKGMGR  (12061): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-06 05:25:24.187+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-06 05:25:24.197+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-06 05:25:24.207+0900 E/PKGMGR_SERVER(12063): pkgmgr-server.c: sighandler(417) > child NORMAL exit [12066]
04-06 05:25:26.639+0900 E/PKGMGR_SERVER(12063): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:25:26.639+0900 E/PKGMGR_SERVER(12063): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:25:28.391+0900 E/PKGMGR  (12152): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-06 05:25:28.461+0900 E/PKGMGR_SERVER(12154): pkgmgr-server.c: main(2414) > package manager server start
04-06 05:25:28.511+0900 E/PKGMGR_SERVER(12154): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-06 05:25:28.521+0900 E/PKGMGR_SERVER(12154): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-06 05:25:28.521+0900 E/PKGMGR  (12152): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[121520002]
04-06 05:25:28.671+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-06 05:25:28.671+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-06 05:25:28.681+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-06 05:25:28.691+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 05:25:28.691+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 05:25:28.691+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.691+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:28.851+0900 W/CERT_SVC_VCORE(12157): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 05:25:28.932+0900 E/rpm-installer(12157): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-06 05:25:28.932+0900 E/rpm-installer(12157): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-06 05:25:28.992+0900 E/PKGMGR_PARSER(12157): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-06 05:25:29.012+0900 I/PRIVACY-MANAGER-CLIENT(12157): SocketClient.cpp: SocketClient(37) > Client created
04-06 05:25:29.012+0900 I/PRIVACY-MANAGER-CLIENT(12157): SocketClient.cpp: connect(62) > Client connected
04-06 05:25:29.012+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-06 05:25:29.012+0900 I/PRIVACY-MANAGER-CLIENT(12157): SocketClient.cpp: disconnect(72) > Client disconnected
04-06 05:25:29.012+0900 E/PKGMGR_CERT(12157): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-06 05:25:29.022+0900 E/PKGMGR_CERT(12157): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-06 05:25:29.022+0900 E/PKGMGR_CERT(12157): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-06 05:25:29.062+0900 E/rpm-installer(12157): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-06 05:25:29.062+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:29.062+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-06 05:25:29.062+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:29.062+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:29.062+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-06 05:25:29.062+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:29.062+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:29.062+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:29.062+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-06 05:25:29.072+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-06 05:25:29.072+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-06 05:25:29.082+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-06 05:25:30.643+0900 E/PKGMGR_SERVER(12154): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 05:25:30.733+0900 E/PKGMGR_SERVER(12154): pkgmgr-server.c: sighandler(417) > child NORMAL exit [12157]
04-06 05:25:31.964+0900 E/PKGMGR  (12205): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-06 05:25:31.995+0900 E/PKGMGR_SERVER(12154): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-06 05:25:32.005+0900 E/PKGMGR_INFO(12154): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-06 05:25:32.015+0900 E/rpm-installer(12154): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-06 05:25:32.015+0900 E/PKGMGR_SERVER(12154): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-06 05:25:32.025+0900 E/PKGMGR  (12205): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[122050002]
04-06 05:25:32.145+0900 E/PKGMGR_INSTALLER(12207): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-06 05:25:32.145+0900 E/rpm-installer(12207): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-06 05:25:32.165+0900 E/rpm-installer(12207): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-06 05:25:32.165+0900 E/rpm-installer(12207): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-06 05:25:32.165+0900 E/rpm-installer(12207): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 05:25:32.165+0900 E/rpm-installer(12207): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-06 05:25:32.165+0900 E/rpm-installer(12207): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 05:25:32.215+0900 W/CERT_SVC_VCORE(12207): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 05:25:32.275+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-06 05:25:32.275+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-06 05:25:32.285+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 05:25:32.285+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 05:25:32.285+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-06 05:25:32.315+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.315+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.315+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.315+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.315+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.315+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.325+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.325+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.325+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.325+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.325+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.325+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.525+0900 E/rpm-installer(12207): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-06 05:25:32.525+0900 E/rpm-installer(12207): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-06 05:25:32.525+0900 E/rpm-installer(12207): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-06 05:25:32.525+0900 E/rpm-installer(12207): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 05:25:32.525+0900 E/rpm-installer(12207): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-06 05:25:32.525+0900 E/rpm-installer(12207): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-06 05:25:32.535+0900 E/PKGMGR_PARSER(12207): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-06 05:25:32.535+0900 E/PKGMGR_PARSER(12207): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-06 05:25:32.585+0900 I/PRIVACY-MANAGER-CLIENT(12207): SocketClient.cpp: SocketClient(37) > Client created
04-06 05:25:32.635+0900 E/PKGMGR_SERVER(12154): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 05:25:32.795+0900 E/PKGMGR_PARSER(12207): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-06 05:25:32.815+0900 E/PKGMGR_CERT(12207): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-06 05:25:32.815+0900 E/PKGMGR_CERT(12207): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-06 05:25:32.815+0900 E/PKGMGR_CERT(12207): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-06 05:25:32.815+0900 E/PKGMGR_CERT(12207): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-06 05:25:32.815+0900 E/PKGMGR_CERT(12207): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-06 05:25:32.815+0900 E/PKGMGR_CERT(12207): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-06 05:25:32.815+0900 E/PKGMGR_CERT(12207): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-06 05:25:32.825+0900 E/PKGMGR_CERT(12207): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-06 05:25:32.835+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.835+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-06 05:25:32.835+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.835+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.835+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-06 05:25:32.835+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.835+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-06 05:25:32.835+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.835+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.845+0900 E/rpm-installer(12207): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 05:25:32.865+0900 E/rpm-installer(12207): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-06 05:25:32.875+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-06 05:25:32.875+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-06 05:25:32.875+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-06 05:25:32.875+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.875+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.875+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.875+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.875+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:32.875+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:34.637+0900 E/PKGMGR_SERVER(12154): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 05:25:34.707+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-06 05:25:34.707+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-06 05:25:34.707+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-06 05:25:34.707+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-06 05:25:34.707+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-06 05:25:34.707+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-06 05:25:34.707+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:34.707+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:34.707+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:34.707+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:34.707+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:34.707+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 05:25:34.717+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-06 05:25:34.727+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-06 05:25:34.727+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-06 05:25:34.727+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-06 05:25:34.727+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-06 05:25:34.727+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-06 05:25:34.737+0900 E/PKGMGR_SERVER(12154): pkgmgr-server.c: sighandler(417) > child NORMAL exit [12207]
04-06 05:25:34.737+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-06 05:25:34.747+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-06 05:25:34.747+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-06 05:25:34.747+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-06 05:25:34.747+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-06 05:25:34.757+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-06 05:25:34.767+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-06 05:25:34.777+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 05:25:34.777+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 05:25:34.777+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-06 05:25:34.777+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-06 05:25:34.777+0900 I/Tizen::App( 1231): (840) > Enter.
04-06 05:25:34.797+0900 I/Tizen::App( 1231): (703) > Exit.
04-06 05:25:34.797+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
04-06 05:25:34.797+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-06 05:25:34.797+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 05:25:34.797+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 05:25:34.797+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-06 05:25:34.797+0900 I/Tizen::App( 1231): (131) > Enter
04-06 05:25:34.807+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-06 05:25:34.807+0900 I/Tizen::App( 1231): (883) > Exit.
04-06 05:25:36.639+0900 E/PKGMGR_SERVER(12154): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 05:25:36.639+0900 E/PKGMGR_SERVER(12154): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 05:25:38.951+0900 W/AUL     (12262): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 05:25:38.951+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 05:25:38.961+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 05:25:38.971+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 05:25:38.971+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 05:25:38.971+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 12262
04-06 05:25:38.971+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 05:25:38.981+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 05:25:38.981+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 05:25:38.981+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 05:25:38.991+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 05:25:38.991+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 05:25:39.001+0900 I/abc     (11662): abc
04-06 05:25:39.001+0900 I/CAPI_APPFW_APPLICATION(11662): app_main.c: ui_app_main(789) > app_efl_main
04-06 05:25:39.001+0900 I/CAPI_APPFW_APPLICATION(11662): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 05:25:39.041+0900 E/TBM     (11662): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 05:25:39.091+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 11662, appid: org.example.client
04-06 05:25:39.091+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 05:25:39.101+0900 W/AUL     (12262): launch.c: app_request_to_launchpad(425) > request cmd(0) result(11662)
04-06 05:25:39.332+0900 D/basicui (11662): successed to load edc file
04-06 05:25:39.362+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:25:39.362+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:25:39.382+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 05:25:39.382+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 05:25:39.382+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 05:25:39.392+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 05:25:39.422+0900 I/MY_LOG  (11662): change
04-06 05:25:39.462+0900 I/APP_CORE(11662): appcore-efl.c: __do_app(514) > [APP 11662] Event: RESET State: CREATED
04-06 05:25:39.462+0900 I/CAPI_APPFW_APPLICATION(11662): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 05:25:39.482+0900 E/EFL     (11662): edje<11662> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:25:39.482+0900 E/EFL     (11662): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:25:39.482+0900 E/EFL     (11662): edje<11662> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:25:39.482+0900 E/EFL     (11662): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:25:39.482+0900 E/EFL     (11662): edje<11662> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 05:25:39.482+0900 E/EFL     (11662): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 05:25:39.492+0900 W/APP_CORE(11662): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
04-06 05:25:39.492+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 05:25:39.602+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 05:25:39.602+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 05:25:39.602+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 05:25:39.612+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 05:25:39.612+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 05:25:39.612+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 05:25:39.612+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(11662) status(3)
04-06 05:25:39.612+0900 I/APP_CORE(11662): appcore-efl.c: __do_app(514) > [APP 11662] Event: RESUME State: CREATED
04-06 05:25:39.612+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:25:39.612+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:25:39.612+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(11662)
04-06 05:25:39.612+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 11662, appid: org.example.client, status: fg
04-06 05:25:39.622+0900 I/APP_CORE(11662): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 05:25:39.622+0900 I/APP_CORE(11662): appcore-efl.c: __do_app(625) > [APP 11662] Initial Launching, call the resume_cb
04-06 05:25:39.622+0900 I/CAPI_APPFW_APPLICATION(11662): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 05:25:39.632+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 05:25:39.632+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 05:25:39.632+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 05:25:39.982+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(11662) status(0)
04-06 05:25:40.172+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2197
04-06 05:25:40.183+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 05:25:40.183+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 11662.
04-06 05:25:40.963+0900 I/UXT     (12275): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 05:25:43.075+0900 E/EFL     (11662): ecore_x<11662> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=221862443
04-06 05:25:43.075+0900 I/MY_LOG  (11662): Button pressed
04-06 05:25:43.185+0900 E/EFL     (11662): ecore_x<11662> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=221862553
04-06 05:25:43.185+0900 E/VCONF   (11662): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 05:25:43.195+0900 E/VCONF   (11662): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 05:25:43.195+0900 E/VCONF   (11662): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 05:25:43.195+0900 E/VCONF   (11662): vconf.c: vconf_get_bool(2729) > vconf_get_bool(11662) : db/ise/keysound error
04-06 05:25:43.195+0900 E/VCONF   (11662): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 05:25:43.195+0900 E/VCONF   (11662): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 05:25:43.256+0900 I/MY_LOG  (11662): Button unpressed
04-06 05:25:43.426+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 05:25:43.436+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 05:25:43.436+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 05:25:43.436+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 05:25:43.436+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 05:25:43.436+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 05:25:43.466+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 05:25:43.476+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 11662 pgid = 11662
04-06 05:25:43.476+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(11662)
04-06 05:25:43.486+0900 E/EFL     (  661): <661> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
04-06 05:25:43.506+0900 W/CRASH_MANAGER(12280): worker.c: worker_job(1199) > 0611662636c69149142394
