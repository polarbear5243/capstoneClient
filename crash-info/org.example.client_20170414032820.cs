S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 9562
Date: 2017-04-14 03:28:20+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9562, uid 5000)

Register Information
r0   = 0xbe905eec, r1   = 0xd2bdf846
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xb282a459, r5   = 0xb83dde50
r6   = 0xb859c3f8, r7   = 0xbe905fd0
r8   = 0x800f9fd3, r9   = 0xb5f2d708
r10  = 0xb85990a0, fp   = 0x00000000
ip   = 0x800f9fd3, sp   = 0xbe905fb8
lr   = 0xb282a47d, pc   = 0xd2bdf844
cpsr = 0x600f0010

Memory Information
MemTotal:   987012 KB
MemFree:    143956 KB
Buffers:     48676 KB
Cached:     324892 KB
VmPeak:     136304 KB
VmSize:     135148 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30768 KB
VmRSS:       29860 KB
VmData:      47036 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35828 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9562 TID = 9562
9562 9563 9816 9817 9826 

Maps Information
af22e000 afa2d000 rw-p [stack:9826]
b0f10000 b0f21000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f31000 b0f36000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13c6000 b13ce000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13e0000 b1bdf000 rw-p [stack:9817]
b1bdf000 b1be0000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bf0000 b1c04000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c18000 b1c19000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c29000 b1c2c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c3d000 b1c3e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c4e000 b1c50000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c60000 b1c62000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c72000 b1c82000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c92000 b1c9e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cb0000 b24af000 rw-p [stack:9816]
b27e0000 b27e7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27fa000 b2800000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2810000 b2838000 r-xp /opt/usr/apps/org.example.client/bin/client
b2991000 b2a74000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2aab000 b2ad3000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ae5000 b32e4000 rw-p [stack:9563]
b32e4000 b32e6000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32f6000 b3300000 r-xp /lib/libnss_files-2.20-2014.11.so
b3311000 b331a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b332b000 b333c000 r-xp /lib/libnsl-2.20-2014.11.so
b334f000 b3355000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3366000 b3367000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b338f000 b3396000 r-xp /usr/lib/libminizip.so.1.0.0
b33a6000 b33ab000 r-xp /usr/lib/libstorage.so.0.1
b33bb000 b341a000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3430000 b3444000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3454000 b3498000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34a8000 b34b0000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34c0000 b34f0000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3503000 b35bc000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35d0000 b3623000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3634000 b364f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b365f000 b3720000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3733000 b3743000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3753000 b3760000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3771000 b3778000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3788000 b37c9000 r-xp /usr/lib/libmdm.so.1.2.12
b37d9000 b37e1000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37f0000 b3800000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3821000 b3881000 r-xp /usr/lib/libasound.so.2.0.0
b3893000 b3896000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38a6000 b38a9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38b9000 b38be000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38ce000 b38cf000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38df000 b38ea000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38fe000 b3905000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3915000 b391b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b392b000 b3930000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3940000 b395b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b396b000 b3972000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3982000 b3985000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3996000 b39c4000 r-xp /usr/lib/libidn.so.11.5.44
b39d4000 b39ea000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39fb000 b3a05000 r-xp /usr/lib/libcares.so.2.1.0
b3a15000 b3a1f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a2f000 b3a31000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a41000 b3a42000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a52000 b3a56000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a67000 b3a8f000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aa0000 b3ac9000 r-xp /usr/lib/libturbojpeg.so
b3ae9000 b3aef000 r-xp /usr/lib/libgif.so.4.1.6
b3aff000 b3b45000 r-xp /usr/lib/libcurl.so.4.3.0
b3b56000 b3b77000 r-xp /usr/lib/libexif.so.12.3.3
b3b92000 b3ba7000 r-xp /usr/lib/libtts.so
b3bb8000 b3bc0000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bd0000 b3c96000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cb6000 b3dae000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dcd000 b3e9b000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eb2000 b3eb4000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ec4000 b3eca000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eda000 b3efd000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f0e000 b3f10000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f20000 b3f22000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f33000 b3f38000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f4f000 b3f51000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f61000 b3f68000 r-xp /usr/lib/libsensord-share.so
b3f78000 b3f90000 r-xp /usr/lib/libsensor.so.1.1.0
b3fa1000 b3fa4000 r-xp /usr/lib/libXv.so.1.0.0
b3fb4000 b3fb9000 r-xp /usr/lib/libutilX.so.1.1.0
b3fc9000 b3fce000 r-xp /usr/lib/libappcore-common.so.1.1
b3fde000 b3fe5000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3ff8000 b3ffc000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b400d000 b40eb000 r-xp /usr/lib/libCOREGL.so.4.0
b410b000 b410e000 r-xp /usr/lib/libuuid.so.1.3.0
b411e000 b4135000 r-xp /usr/lib/libblkid.so.1.1.0
b4146000 b4148000 r-xp /usr/lib/libXau.so.6.0.0
b4158000 b419f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41b1000 b41b7000 r-xp /usr/lib/libjson-c.so.2.0.1
b41c8000 b41cc000 r-xp /usr/lib/libogg.so.0.7.1
b41dc000 b41fe000 r-xp /usr/lib/libvorbis.so.0.4.3
b420e000 b42f2000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b430e000 b4311000 r-xp /usr/lib/libEGL.so.1.4
b4322000 b4328000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4338000 b433a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b434a000 b4357000 r-xp /usr/lib/libGLESv2.so.2.0
b4368000 b43ca000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43df000 b43f7000 r-xp /usr/lib/libmount.so.1.1.0
b4409000 b441d000 r-xp /usr/lib/libxcb.so.1.1.0
b442d000 b4434000 r-xp /lib/libcrypt-2.20-2014.11.so
b446c000 b446e000 r-xp /usr/lib/libiri.so
b447e000 b4489000 r-xp /usr/lib/libgpg-error.so.0.15.0
b449a000 b44d0000 r-xp /usr/lib/libpulse.so.0.16.2
b44e1000 b4524000 r-xp /usr/lib/libsndfile.so.1.0.25
b4539000 b454e000 r-xp /lib/libexpat.so.1.5.2
b4560000 b461e000 r-xp /usr/lib/libcairo.so.2.11200.14
b4632000 b463a000 r-xp /usr/lib/libdrm.so.2.4.0
b464a000 b464d000 r-xp /usr/lib/libdri2.so.0.0.0
b465d000 b46ab000 r-xp /usr/lib/libssl.so.1.0.0
b46c0000 b46cc000 r-xp /usr/lib/libeeze.so.1.13.0
b46dd000 b46e6000 r-xp /usr/lib/libethumb.so.1.13.0
b46f6000 b46f9000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4709000 b48c0000 r-xp /usr/lib/libcrypto.so.1.0.0
b56ab000 b56b4000 r-xp /usr/lib/libXi.so.6.1.0
b56c4000 b56c6000 r-xp /usr/lib/libXgesture.so.7.0.0
b56d6000 b56da000 r-xp /usr/lib/libXtst.so.6.1.0
b56ea000 b56f0000 r-xp /usr/lib/libXrender.so.1.3.0
b5700000 b5706000 r-xp /usr/lib/libXrandr.so.2.2.0
b5716000 b5718000 r-xp /usr/lib/libXinerama.so.1.0.0
b5729000 b572c000 r-xp /usr/lib/libXfixes.so.3.1.0
b573c000 b5747000 r-xp /usr/lib/libXext.so.6.4.0
b5757000 b5759000 r-xp /usr/lib/libXdamage.so.1.1.0
b5769000 b576b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b577b000 b585d000 r-xp /usr/lib/libX11.so.6.3.0
b5871000 b5878000 r-xp /usr/lib/libXcursor.so.1.0.2
b5888000 b58a0000 r-xp /usr/lib/libudev.so.1.6.0
b58a2000 b58a5000 r-xp /lib/libattr.so.1.1.0
b58b5000 b58d5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58d6000 b58db000 r-xp /usr/lib/libffi.so.6.0.2
b58ec000 b5904000 r-xp /lib/libz.so.1.2.8
b5914000 b5916000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5926000 b59fb000 r-xp /usr/lib/libxml2.so.2.9.2
b5a10000 b5aab000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ac7000 b5aca000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ada000 b5af3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b04000 b5b15000 r-xp /lib/libresolv-2.20-2014.11.so
b5b29000 b5ba3000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bb8000 b5bba000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bca000 b5bd1000 r-xp /usr/lib/libembryo.so.1.13.0
b5be1000 b5beb000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bfc000 b5c14000 r-xp /usr/lib/libpng12.so.0.50.0
b5c25000 b5c48000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c69000 b5c7d000 r-xp /usr/lib/libector.so.1.13.0
b5c8e000 b5ca6000 r-xp /usr/lib/liblua-5.1.so
b5cb7000 b5d0e000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d22000 b5d4a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d5b000 b5d6e000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d7f000 b5db9000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dca000 b5dd8000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5de8000 b5df0000 r-xp /usr/lib/libtbm.so.1.0.0
b5e00000 b5e0d000 r-xp /usr/lib/libeio.so.1.13.0
b5e1d000 b5e1f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e2f000 b5e34000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e44000 b5e5b000 r-xp /usr/lib/libefreet.so.1.13.0
b5e6d000 b5e8d000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e9d000 b5ebd000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ebf000 b5ec5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ed5000 b5ee6000 r-xp /usr/lib/libemotion.so.1.13.0
b5ef7000 b5efe000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f0e000 b5f1d000 r-xp /usr/lib/libeo.so.1.13.0
b5f2e000 b5f40000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f51000 b5f56000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f66000 b5f7f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f8f000 b5fac000 r-xp /usr/lib/libeet.so.1.13.0
b5fc5000 b600d000 r-xp /usr/lib/libeina.so.1.13.0
b601e000 b602e000 r-xp /usr/lib/libefl.so.1.13.0
b603f000 b6124000 r-xp /usr/lib/libicuuc.so.51.1
b6141000 b6281000 r-xp /usr/lib/libicui18n.so.51.1
b6298000 b62d0000 r-xp /usr/lib/libecore_x.so.1.13.0
b62e2000 b62e5000 r-xp /lib/libcap.so.2.21
b62f5000 b631e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b632f000 b6336000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6348000 b637f000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6390000 b647b000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b648e000 b6507000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6519000 b651e000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b652e000 b6538000 r-xp /usr/lib/libvconf.so.0.2.45
b6548000 b654a000 r-xp /usr/lib/libvasum.so.0.3.1
b655a000 b655c000 r-xp /usr/lib/libttrace.so.1.1
b656c000 b656f000 r-xp /usr/lib/libiniparser.so.0
b657f000 b65a5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65b5000 b65ba000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65cb000 b65e2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65f3000 b665e000 r-xp /lib/libm-2.20-2014.11.so
b666f000 b6675000 r-xp /lib/librt-2.20-2014.11.so
b6686000 b6693000 r-xp /usr/lib/libunwind.so.8.0.1
b66c9000 b67ed000 r-xp /lib/libc-2.20-2014.11.so
b6802000 b681b000 r-xp /lib/libgcc_s-4.9.so.1
b682b000 b690d000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b691e000 b6948000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6959000 b6995000 r-xp /usr/lib/libsystemd.so.0.4.0
b6997000 b6a1a000 r-xp /usr/lib/libedje.so.1.13.0
b6a2d000 b6a4b000 r-xp /usr/lib/libecore.so.1.13.0
b6a6b000 b6bf2000 r-xp /usr/lib/libevas.so.1.13.0
b6c27000 b6c3b000 r-xp /lib/libpthread-2.20-2014.11.so
b6c4f000 b6e83000 r-xp /usr/lib/libelementary.so.1.13.0
b6eb2000 b6eb6000 r-xp /usr/lib/libsmack.so.1.0.0
b6ec6000 b6ecd000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6edd000 b6edf000 r-xp /usr/lib/libdlog.so.0.0.0
b6eef000 b6ef2000 r-xp /usr/lib/libbundle.so.0.1.22
b6f02000 b6f04000 r-xp /lib/libdl-2.20-2014.11.so
b6f15000 b6f2d000 r-xp /usr/lib/libaul.so.0.1.0
b6f41000 b6f46000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f57000 b6f64000 r-xp /usr/lib/liblptcp.so
b6f76000 b6f7a000 r-xp /usr/lib/libsys-assert.so
b6f8b000 b6fab000 r-xp /lib/ld-2.20-2014.11.so
b6fbc000 b6fc1000 r-xp /usr/bin/launchpad-loader
b80ef000 b8608000 rw-p [heap]
be8e6000 be907000 rw-p [stack]
be8e6000 be907000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9562)
Call Stack Count: 1
 0: (0xd2bdf844) (null)
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
return
04-14 03:27:00.270+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(195) > ""
04-14 03:27:00.270+0900 E/UXT     (  645): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:27
04-14 03:27:00.270+0900 I/INDICATOR(  645): clock.c: getTimeFormatted(176) > "time format : 오전 3:27"
04-14 03:27:00.270+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:27"
04-14 03:27:00.270+0900 W/INDICATOR(  645): clock.c: indicator_clock_changed_cb(272) > 
04-14 03:27:00.270+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145642824 Time: <font_size=31> </font_size> <font_size=31> 오전 3:27</font_size></font>"
04-14 03:27:35.625+0900 E/PKGMGR_SERVER( 9604): pkgmgr-server.c: main(2414) > package manager server start
04-14 03:27:35.675+0900 E/PKGMGR  ( 9602): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-14 03:27:35.705+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 14
04-14 03:27:35.705+0900 W/AUL_AMD (  616): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 9471
04-14 03:27:35.705+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 12
04-14 03:27:35.705+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5519)
04-14 03:27:35.705+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:27:35.705+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(5519) is dead. cmd(5) is canceled
04-14 03:27:35.705+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:27:35.705+0900 E/PKGMGR_SERVER( 9607): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:27:35.705+0900 E/PKGMGR_SERVER( 9607): [0;m
04-14 03:27:35.705+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5648)
04-14 03:27:35.705+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:27:35.715+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(5648) is dead. cmd(5) is canceled
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:27:35.715+0900 E/PKGMGR_SERVER( 9607): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:27:35.715+0900 E/PKGMGR_SERVER( 9607): [0;m
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5778)
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:27:35.715+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(5778) is dead. cmd(5) is canceled
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:27:35.715+0900 E/PKGMGR_SERVER( 9607): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:27:35.715+0900 E/PKGMGR_SERVER( 9607): [0;m
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6394)
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:27:35.715+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(6394) is dead. cmd(5) is canceled
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:27:35.715+0900 E/PKGMGR_SERVER( 9607): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:27:35.715+0900 E/PKGMGR_SERVER( 9607): [0;m
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(396) > request cmd(5) to(8127)
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:27:35.715+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(8127) is dead. cmd(5) is canceled
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:27:35.715+0900 E/PKGMGR_SERVER( 9607): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:27:35.715+0900 E/PKGMGR_SERVER( 9607): [0;m
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(396) > request cmd(5) to(8496)
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:27:35.715+0900 E/AUL_AMD (  616): amd_request.c: __app_process_by_pid(272) > pid(8496) is dead. cmd(5) is canceled
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-14 03:27:35.715+0900 E/PKGMGR_SERVER( 9607): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-14 03:27:35.715+0900 E/PKGMGR_SERVER( 9607): [0;m
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(396) > request cmd(5) to(9471)
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 5
04-14 03:27:35.715+0900 I/APP_CORE( 9471): appcore-efl.c: __do_app(514) > [APP 9471] Event: TERMINATE State: RUNNING
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(9471), cmd(4)
04-14 03:27:35.715+0900 W/AUL     ( 9607): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 14
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 9471
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 22
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(1201) > app status : 5
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 22
04-14 03:27:35.715+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(1201) > app status : 5
04-14 03:27:35.725+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 9471): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 9
04-14 03:27:35.725+0900 E/APP_CORE( 9471): appcore-efl.c: _capture_and_make_file(1619) > win[6000002] widget[720] height[1280]
04-14 03:27:35.725+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 33
04-14 03:27:35.725+0900 E/APP_CORE( 9471): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-14 03:27:35.735+0900 I/CAPI_APPFW_APPLICATION( 9471): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:27:35.735+0900 I/CAPI_APPFW_APPLICATION( 9471): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-14 03:27:35.735+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:27:35.735+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
04-14 03:27:35.735+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:27:35.735+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:27:35.735+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
04-14 03:27:35.735+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
04-14 03:27:35.765+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
04-14 03:27:35.805+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
04-14 03:27:35.805+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:27:35.805+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
04-14 03:27:35.805+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:27:35.815+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 14
04-14 03:27:35.815+0900 W/AUL_AMD (  616): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-14 03:27:35.825+0900 E/PKGMGR_SERVER( 9604): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9607]
04-14 03:27:35.835+0900 I/Tizen::System( 1305): (259) > Active app [com.samsun], current [org.exampl] 
04-14 03:27:35.835+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:27:35.845+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:27:35.845+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-14 03:27:35.845+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:27:35.845+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-14 03:27:35.845+0900 I/TIZEN_N_SOUND_MANAGER(  905): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-14 03:27:35.845+0900 E/TIZEN_N_SOUND_MANAGER(  905): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-14 03:27:35.855+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:27:35.875+0900 E/weather-widget( 1405): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-14 03:27:35.915+0900 E/weather-common( 1405): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-14 03:27:35.965+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_create(409) > New handle created[0xb8758610]
04-14 03:27:35.965+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_get_type(463) > Connected Network = 2
04-14 03:27:35.965+0900 I/CAPI_NETWORK_CONNECTION( 1405): connection.c: connection_destroy(427) > Destroy handle: 0xb8758610
04-14 03:27:35.965+0900 E/weather-common( 1405): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-14 03:27:35.965+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-14 03:27:35.965+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-14 03:27:35.965+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-14 03:27:35.965+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: fg
04-14 03:27:36.055+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9471 pgid = 9471
04-14 03:27:36.055+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(143) > dead_pid(9471)
04-14 03:27:36.085+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-14 03:27:36.085+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-14 03:27:36.085+0900 E/AUL_PAD ( 1560): launchpad.c: main(698) > error reading sigchld info
04-14 03:27:36.085+0900 I/ESD     (  895): esd_main.c: __esd_app_dead_handler(1773) > pid: 9471
04-14 03:27:36.085+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9471
04-14 03:27:36.095+0900 I/Tizen::App( 1305): (243) > App[org.example.client] pid[9471] terminate event is forwarded
04-14 03:27:36.095+0900 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
04-14 03:27:36.095+0900 I/Tizen::System( 1305): (196) > Accessory Owner is removed [org.example.client, 9471, ]
04-14 03:27:36.095+0900 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
04-14 03:27:36.095+0900 I/Tizen::App( 1305): (506) > TerminatedApp(org.example.client)
04-14 03:27:36.095+0900 I/Tizen::App( 1305): (512) > Not registered pid(9471)
04-14 03:27:36.095+0900 I/Tizen::System( 1305): (246) > Terminated app [org.example.client]
04-14 03:27:36.095+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:27:36.095+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.709
04-14 03:27:36.105+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:27:36.105+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 9471.
04-14 03:27:37.557+0900 E/PKGMGR_SERVER( 9604): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-14 03:27:37.557+0900 E/PKGMGR_SERVER( 9604): pkgmgr-server.c: main(2471) > package manager server terminated.
04-14 03:27:39.769+0900 E/PKGMGR  ( 9697): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-14 03:27:39.839+0900 E/PKGMGR_SERVER( 9699): pkgmgr-server.c: main(2414) > package manager server start
04-14 03:27:39.889+0900 E/PKGMGR_SERVER( 9699): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-14 03:27:39.899+0900 E/PKGMGR_SERVER( 9699): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-14 03:27:39.899+0900 E/PKGMGR  ( 9697): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[96970002]
04-14 03:27:40.049+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-14 03:27:40.049+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-14 03:27:40.059+0900 W/AUL_AMD (  616): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-14 03:27:40.069+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-14 03:27:40.069+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [30]
04-14 03:27:40.069+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-14 03:27:40.239+0900 W/CERT_SVC_VCORE( 9702): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-14 03:27:40.339+0900 E/rpm-installer( 9702): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-14 03:27:40.339+0900 E/rpm-installer( 9702): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-14 03:27:40.389+0900 E/PKGMGR_PARSER( 9702): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-14 03:27:40.409+0900 I/PRIVACY-MANAGER-CLIENT( 9702): SocketClient.cpp: SocketClient(37) > Client created
04-14 03:27:40.409+0900 I/PRIVACY-MANAGER-CLIENT( 9702): SocketClient.cpp: connect(62) > Client connected
04-14 03:27:40.409+0900 I/PRIVACY-MANAGER-SERVER(  910): SocketService.cpp: mainloop(230) > Got incoming connection
04-14 03:27:40.409+0900 I/PRIVACY-MANAGER-CLIENT( 9702): SocketClient.cpp: disconnect(72) > Client disconnected
04-14 03:27:40.419+0900 E/PKGMGR_CERT( 9702): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-14 03:27:40.419+0900 E/PKGMGR_CERT( 9702): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-14 03:27:40.429+0900 E/PKGMGR_CERT( 9702): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-14 03:27:40.460+0900 E/rpm-installer( 9702): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-14 03:27:40.470+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-14 03:27:40.470+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-14 03:27:40.470+0900 E/ESD     (  895): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-14 03:27:40.480+0900 W/AUL_AMD (  616): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-14 03:27:40.480+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-14 03:27:40.480+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-14 03:27:40.720+0900 W/AUL_AMD (  616): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-14 03:27:40.720+0900 W/AUL_AMD (  616): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-14 03:27:42.171+0900 E/PKGMGR_SERVER( 9699): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9702]
04-14 03:27:42.552+0900 E/PKGMGR_SERVER( 9699): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-14 03:27:42.552+0900 E/PKGMGR_SERVER( 9699): pkgmgr-server.c: main(2471) > package manager server terminated.
04-14 03:27:43.162+0900 E/PKGMGR  ( 9750): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-14 03:27:43.242+0900 E/PKGMGR_SERVER( 9752): pkgmgr-server.c: main(2414) > package manager server start
04-14 03:27:43.292+0900 E/PKGMGR_SERVER( 9752): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-14 03:27:43.302+0900 E/PKGMGR_INFO( 9752): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-14 03:27:43.312+0900 E/rpm-installer( 9752): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-14 03:27:43.312+0900 E/PKGMGR_SERVER( 9752): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-14 03:27:43.322+0900 E/PKGMGR  ( 9750): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[97500002]
04-14 03:27:43.442+0900 E/PKGMGR_INSTALLER( 9755): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-14 03:27:43.442+0900 E/rpm-installer( 9755): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-14 03:27:43.462+0900 E/rpm-installer( 9755): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-14 03:27:43.462+0900 E/rpm-installer( 9755): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-14 03:27:43.462+0900 E/rpm-installer( 9755): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-14 03:27:43.462+0900 E/rpm-installer( 9755): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-14 03:27:43.462+0900 E/rpm-installer( 9755): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-14 03:27:43.522+0900 W/CERT_SVC_VCORE( 9755): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-14 03:27:43.573+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-14 03:27:43.573+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-14 03:27:43.583+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-14 03:27:43.583+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [30]
04-14 03:27:43.583+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-14 03:27:43.833+0900 E/rpm-installer( 9755): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-14 03:27:43.833+0900 E/rpm-installer( 9755): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-14 03:27:43.833+0900 E/rpm-installer( 9755): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-14 03:27:43.833+0900 E/rpm-installer( 9755): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-14 03:27:43.833+0900 E/rpm-installer( 9755): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-14 03:27:43.833+0900 E/rpm-installer( 9755): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-14 03:27:43.843+0900 E/PKGMGR_PARSER( 9755): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-14 03:27:43.843+0900 E/PKGMGR_PARSER( 9755): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-14 03:27:43.883+0900 I/PRIVACY-MANAGER-CLIENT( 9755): SocketClient.cpp: SocketClient(37) > Client created
04-14 03:27:44.093+0900 E/PKGMGR_PARSER( 9755): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-14 03:27:44.113+0900 E/PKGMGR_CERT( 9755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-14 03:27:44.113+0900 E/PKGMGR_CERT( 9755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
04-14 03:27:44.113+0900 E/PKGMGR_CERT( 9755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
04-14 03:27:44.113+0900 E/PKGMGR_CERT( 9755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-14 03:27:44.113+0900 E/PKGMGR_CERT( 9755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
04-14 03:27:44.113+0900 E/PKGMGR_CERT( 9755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
04-14 03:27:44.113+0900 E/PKGMGR_CERT( 9755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-14 03:27:44.123+0900 E/PKGMGR_CERT( 9755): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-14 03:27:44.123+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-14 03:27:44.123+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [60]
04-14 03:27:44.123+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-14 03:27:44.143+0900 E/rpm-installer( 9755): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-14 03:27:44.163+0900 E/rpm-installer( 9755): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-14 03:27:44.163+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-14 03:27:44.163+0900 I/Tizen::App( 1305): (119) > InstallationInProgress [100]
04-14 03:27:44.163+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-14 03:27:45.394+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:27:45.394+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:27:45.554+0900 E/PKGMGR_SERVER( 9752): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-14 03:27:46.125+0900 I/Tizen::App( 1305): (1894) > PackageEventHandler - req: 13050002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-14 03:27:46.125+0900 I/Tizen::App( 1305): (78) > Installation is Completed. [Package = org.example.client]
04-14 03:27:46.125+0900 I/Tizen::App( 1305): (671) > Enter. package(org.example.client), installationResult(0)
04-14 03:27:46.125+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-14 03:27:46.125+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-14 03:27:46.125+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-14 03:27:46.175+0900 W/ISF_PANEL_EFL(  681): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-14 03:27:46.215+0900 I/Tizen::App( 1305): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-14 03:27:46.235+0900 I/Tizen::App( 1305): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-14 03:27:46.245+0900 I/Tizen::App( 1305): (416) > appName = [client]
04-14 03:27:46.245+0900 I/Tizen::App( 1305): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-14 03:27:46.245+0900 E/PKGMGR_INFO( 1305): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-14 03:27:46.245+0900 I/Tizen::App( 1305): (683) > Application count(1) in this package
04-14 03:27:46.245+0900 I/Tizen::App( 1305): (840) > Enter.
04-14 03:27:46.255+0900 I/Tizen::App( 1305): (703) > Exit.
04-14 03:27:46.255+0900 I/Tizen::App( 1305): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-14 03:27:46.255+0900 I/Tizen::App( 1305): (416) > appName = [client]
04-14 03:27:46.255+0900 I/Tizen::App( 1305): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-14 03:27:46.255+0900 I/Tizen::App( 1305): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-14 03:27:46.255+0900 I/Tizen::App( 1305): (131) > Enter
04-14 03:27:46.255+0900 I/Tizen::App( 1305): (137) > org.example.client does not have launch condition
04-14 03:27:46.255+0900 I/Tizen::App( 1305): (883) > Exit.
04-14 03:27:46.265+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-14 03:27:46.265+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-14 03:27:46.265+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-14 03:27:46.265+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-14 03:27:46.265+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-14 03:27:46.275+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-14 03:27:46.275+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-14 03:27:46.275+0900 E/PKGMGR_SERVER( 9752): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9755]
04-14 03:27:46.285+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-14 03:27:46.285+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-14 03:27:46.305+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-14 03:27:46.315+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-14 03:27:47.556+0900 E/PKGMGR_SERVER( 9752): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-14 03:27:47.556+0900 E/PKGMGR_SERVER( 9752): pkgmgr-server.c: main(2471) > package manager server terminated.
04-14 03:27:50.379+0900 W/AUL     ( 9809): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-14 03:27:50.379+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 0
04-14 03:27:50.389+0900 I/AUL     (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-14 03:27:50.399+0900 I/AUL     (  616): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-14 03:27:50.399+0900 E/AUL_AMD (  616): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-14 03:27:50.399+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(2508) > caller pid : 9809
04-14 03:27:50.399+0900 E/AUL_AMD (  616): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-14 03:27:50.409+0900 E/RESOURCED(  648): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-14 03:27:50.409+0900 E/RESOURCED(  648): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-14 03:27:50.409+0900 W/AUL_AMD (  616): amd_launch.c: _start_app(3052) > pad pid(-5)
04-14 03:27:50.409+0900 W/AUL_PAD ( 1560): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-14 03:27:50.409+0900 W/AUL_PAD ( 1560): launchpad.c: __send_result_to_caller(267) > Check app launching
04-14 03:27:50.429+0900 I/abc     ( 9562): abc
04-14 03:27:50.429+0900 I/CAPI_APPFW_APPLICATION( 9562): app_main.c: ui_app_main(789) > app_efl_main
04-14 03:27:50.429+0900 I/CAPI_APPFW_APPLICATION( 9562): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-14 03:27:50.459+0900 E/TBM     ( 9562): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-14 03:27:50.509+0900 W/AUL     (  616): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9562, appid: org.example.client
04-14 03:27:50.509+0900 E/AUL     (  616): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-14 03:27:50.519+0900 W/AUL     ( 9809): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9562)
04-14 03:27:50.750+0900 I/APP_CORE( 9562): appcore-efl.c: __do_app(514) > [APP 9562] Event: RESET State: CREATED
04-14 03:27:50.750+0900 I/CAPI_APPFW_APPLICATION( 9562): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-14 03:27:50.760+0900 E/EFL     ( 9562): edje<9562> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:27:50.760+0900 E/EFL     ( 9562): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:27:50.770+0900 E/EFL     ( 9562): edje<9562> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:27:50.770+0900 E/EFL     ( 9562): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:27:50.770+0900 E/EFL     ( 9562): edje<9562> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-14 03:27:50.770+0900 E/EFL     ( 9562): By the power of Grayskull, your previous Embryo stack is now broken!
04-14 03:27:50.780+0900 W/APP_CORE( 9562): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
04-14 03:27:50.780+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 35
04-14 03:27:50.790+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:27:50.790+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:27:50.800+0900 I/Tizen::System( 1305): (259) > Active app [org.exampl], current [com.samsun] 
04-14 03:27:50.800+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:27:50.810+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:27:50.820+0900 W/AUL_AMD (  616): amd_request.c: __request_handler(906) > __request_handler: 15
04-14 03:27:50.890+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
04-14 03:27:50.890+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-14 03:27:50.890+0900 I/APP_CORE( 9562): appcore-efl.c: __do_app(514) > [APP 9562] Event: RESUME State: CREATED
04-14 03:27:50.890+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
04-14 03:27:50.900+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
04-14 03:27:50.900+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
04-14 03:27:50.900+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
04-14 03:27:50.900+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9562) status(3)
04-14 03:27:50.900+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:27:50.900+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:27:50.900+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(9562)
04-14 03:27:50.900+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9562, appid: org.example.client, status: fg
04-14 03:27:50.910+0900 I/APP_CORE( 9562): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-14 03:27:50.910+0900 I/APP_CORE( 9562): appcore-efl.c: __do_app(625) > [APP 9562] Initial Launching, call the resume_cb
04-14 03:27:50.910+0900 I/CAPI_APPFW_APPLICATION( 9562): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:27:50.910+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-14 03:27:50.910+0900 I/CAPI_WIDGET_APPLICATION( 1405): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-14 03:27:50.910+0900 W/AUL     ( 1405): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1405, appid: com.samsung.weather-m-widget, status: bg
04-14 03:27:51.260+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(9562) status(0)
04-14 03:27:51.580+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.719
04-14 03:27:51.590+0900 I/Tizen::App( 1305): (499) > LaunchedApp(org.example.client)
04-14 03:27:51.590+0900 I/Tizen::App( 1305): (733) > Finished invoking application event listener for org.example.client, 9562.
04-14 03:27:51.771+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=28998830
04-14 03:27:51.771+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=28999215
04-14 03:27:52.371+0900 I/UXT     ( 9822): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-14 03:27:55.895+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
04-14 03:28:00.279+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(195) > ""
04-14 03:28:00.279+0900 E/UXT     (  645): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:28
04-14 03:28:00.279+0900 I/INDICATOR(  645): clock.c: getTimeFormatted(176) > "time format : 오전 3:28"
04-14 03:28:00.279+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:28"
04-14 03:28:00.279+0900 W/INDICATOR(  645): clock.c: indicator_clock_changed_cb(272) > 
04-14 03:28:00.279+0900 I/INDICATOR(  645): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145592565 Time: <font_size=31> </font_size> <font_size=31> 오전 3:28</font_size></font>"
04-14 03:28:08.187+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29015632
04-14 03:28:08.187+0900 I/MY_LOG  ( 9562): Button pressed
04-14 03:28:08.277+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29015720
04-14 03:28:08.277+0900 E/VCONF   ( 9562): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-14 03:28:08.277+0900 E/VCONF   ( 9562): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-14 03:28:08.277+0900 E/VCONF   ( 9562): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-14 03:28:08.277+0900 E/VCONF   ( 9562): vconf.c: vconf_get_bool(2729) > vconf_get_bool(9562) : db/ise/keysound error
04-14 03:28:08.277+0900 E/VCONF   ( 9562): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-14 03:28:08.277+0900 E/VCONF   ( 9562): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-14 03:28:08.357+0900 I/MY_LOG  ( 9562): Button unpressed
04-14 03:28:09.077+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29016520
04-14 03:28:09.077+0900 I/MY_LOG  ( 9562): Button pressed
04-14 03:28:09.137+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29016586
04-14 03:28:09.147+0900 I/MY_LOG  ( 9562): Button unpressed
04-14 03:28:09.178+0900 D/basicui ( 9562): successed to load edc file
04-14 03:28:10.579+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29018021
04-14 03:28:10.679+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29018120
04-14 03:28:10.709+0900 D/basicui ( 9562): successed to load edc file
04-14 03:28:10.729+0900 I/MY_LOG  ( 9562): change
04-14 03:28:10.749+0900 E/EFL     ( 9562): evas_main<9562> lib/evas/common/evas_text_utils.c:285 evas_common_text_props_split() Couldn't find the cutoff position. Is it inside a cluster?
04-14 03:28:10.749+0900 E/EFL     ( 9562): evas_main<9562> lib/evas/common/evas_text_utils.c:285 evas_common_text_props_split() Couldn't find the cutoff position. Is it inside a cluster?
04-14 03:28:10.759+0900 E/EFL     ( 9562): evas_main<9562> lib/evas/common/evas_text_utils.c:285 evas_common_text_props_split() Couldn't find the cutoff position. Is it inside a cluster?
04-14 03:28:10.759+0900 E/EFL     ( 9562): evas_main<9562> lib/evas/common/evas_text_utils.c:285 evas_common_text_props_split() Couldn't find the cutoff position. Is it inside a cluster?
04-14 03:28:10.759+0900 E/EFL     ( 9562): evas_main<9562> lib/evas/common/evas_text_utils.c:285 evas_common_text_props_split() Couldn't find the cutoff position. Is it inside a cluster?
04-14 03:28:10.759+0900 E/EFL     ( 9562): evas_main<9562> lib/evas/common/evas_text_utils.c:285 evas_common_text_props_split() Couldn't find the cutoff position. Is it inside a cluster?
04-14 03:28:10.759+0900 E/EFL     ( 9562): evas_main<9562> lib/evas/common/evas_text_utils.c:285 evas_common_text_props_split() Couldn't find the cutoff position. Is it inside a cluster?
04-14 03:28:10.759+0900 E/EFL     ( 9562): evas_main<9562> lib/evas/common/evas_text_utils.c:285 evas_common_text_props_split() Couldn't find the cutoff position. Is it inside a cluster?
04-14 03:28:10.819+0900 I/MY_LOG  ( 9562): change
04-14 03:28:10.999+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:28:10.999+0900 E/INDICATOR(  645): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-14 03:28:18.547+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29025991
04-14 03:28:19.548+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=29026996
04-14 03:28:20.128+0900 E/EFL     ( 9562): ecore_x<9562> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=29027574
04-14 03:28:20.268+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9562 pgid = 9562
04-14 03:28:20.268+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(143) > dead_pid(9562)
04-14 03:28:20.268+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:28:20.318+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
04-14 03:28:20.318+0900 W/AUL_AMD (  616): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-14 03:28:20.318+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-14 03:28:20.318+0900 W/AUL     (  616): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
04-14 03:28:20.318+0900 W/AUL     (  616): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
04-14 03:28:20.358+0900 I/AUL_PAD ( 1560): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-14 03:28:20.358+0900 I/AUL_PAD ( 1560): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-14 03:28:20.358+0900 E/AUL_PAD ( 1560): launchpad.c: main(698) > error reading sigchld info
04-14 03:28:20.358+0900 I/ESD     (  895): esd_main.c: __esd_app_dead_handler(1773) > pid: 9562
04-14 03:28:20.358+0900 I/Tizen::App( 1305): (243) > App[org.example.client] pid[9562] terminate event is forwarded
04-14 03:28:20.358+0900 I/Tizen::System( 1305): (256) > osp.accessorymanager.service provider is found.
04-14 03:28:20.358+0900 I/Tizen::System( 1305): (196) > Accessory Owner is removed [org.example.client, 9562, ]
04-14 03:28:20.358+0900 I/Tizen::System( 1305): (256) > osp.system.service provider is found.
04-14 03:28:20.358+0900 I/Tizen::App( 1305): (506) > TerminatedApp(org.example.client)
04-14 03:28:20.358+0900 I/Tizen::App( 1305): (512) > Not registered pid(9562)
04-14 03:28:20.358+0900 I/Tizen::System( 1305): (246) > Terminated app [org.example.client]
04-14 03:28:20.358+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:28:20.358+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9562
04-14 03:28:20.358+0900 W/AUL_AMD (  616): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9562
04-14 03:28:20.358+0900 E/RESOURCED(  648): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.723
04-14 03:28:20.368+0900 W/AUL_AMD (  616): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
04-14 03:28:20.368+0900 I/Tizen::System( 1305): (157) > change brightness system value.
04-14 03:28:20.368+0900 I/Tizen::App( 1305): (782) > Finished invoking application event listener for org.example.client, 9562.
04-14 03:28:20.378+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
04-14 03:28:20.378+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-14 03:28:20.378+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
04-14 03:28:20.388+0900 E/EFL     (  334): eo<334> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-14 03:28:20.398+0900 I/Tizen::System( 1305): (259) > Active app [com.samsun], current [org.exampl] 
04-14 03:28:20.398+0900 I/Tizen::Io( 1305): (729) > Entry not found
04-14 03:28:20.418+0900 E/weather-widget( 1405): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-14 03:28:20.429+0900 W/CRASH_MANAGER( 9830): worker.c: worker_job(1199) > 1109562636c69149210810
