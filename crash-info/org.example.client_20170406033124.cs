S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 8892
Date: 2017-04-06 03:31:24+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 8892, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000022bc
r2   = 0x00000006, r3   = 0xb406d4c0
r4   = 0x00000002, r5   = 0xb406d000
r6   = 0xb676709c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5e95708
r10  = 0xb8d87950, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbeb78ecc
lr   = 0xb665df18, pc   = 0xb665cb84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     78756 KB
Buffers:     61156 KB
Cached:     286488 KB
VmPeak:     133900 KB
VmSize:     133896 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28296 KB
VmRSS:       28296 KB
VmData:      45844 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8892 TID = 8892
8892 8893 8959 8960 8969 

Maps Information
af12e000 af92d000 rw-p [stack:8969]
b0f14000 b0f25000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f35000 b0f3a000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b133c000 b1344000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1356000 b1b55000 rw-p [stack:8960]
b1b55000 b1b56000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b66000 b1b7a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b8e000 b1b8f000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b9f000 b1ba2000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bb3000 b1bb4000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bc4000 b1bc6000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bd6000 b1bd8000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1be8000 b1bf8000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c08000 b1c14000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c26000 b2425000 rw-p [stack:8959]
b2756000 b275d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2770000 b2776000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2786000 b27a1000 r-xp /opt/usr/apps/org.example.client/bin/client
b28f9000 b29dc000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a13000 b2a3b000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a4d000 b324c000 rw-p [stack:8893]
b324c000 b324e000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b325e000 b3268000 r-xp /lib/libnss_files-2.20-2014.11.so
b3279000 b3282000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3293000 b32a4000 r-xp /lib/libnsl-2.20-2014.11.so
b32b7000 b32bd000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32ce000 b32cf000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32f7000 b32fe000 r-xp /usr/lib/libminizip.so.1.0.0
b330e000 b3313000 r-xp /usr/lib/libstorage.so.0.1
b3323000 b3382000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3398000 b33ac000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33bc000 b3400000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3410000 b3418000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3428000 b3458000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b346b000 b3524000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3538000 b358b000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b359c000 b35b7000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35c7000 b3688000 r-xp /usr/lib/libprotobuf.so.9.0.1
b369b000 b36ab000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36bb000 b36c8000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36d9000 b36e0000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36f0000 b3731000 r-xp /usr/lib/libmdm.so.1.2.12
b3741000 b3749000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3758000 b3768000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3789000 b37e9000 r-xp /usr/lib/libasound.so.2.0.0
b37fb000 b37fe000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b380e000 b3811000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3821000 b3826000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3836000 b3837000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3847000 b3852000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3866000 b386d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b387d000 b3883000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3893000 b3898000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38a8000 b38c3000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38d3000 b38da000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38ea000 b38ed000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38fe000 b392c000 r-xp /usr/lib/libidn.so.11.5.44
b393c000 b3952000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3963000 b396d000 r-xp /usr/lib/libcares.so.2.1.0
b397d000 b3987000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3997000 b3999000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39a9000 b39aa000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39ba000 b39be000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39cf000 b39f7000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a08000 b3a31000 r-xp /usr/lib/libturbojpeg.so
b3a51000 b3a57000 r-xp /usr/lib/libgif.so.4.1.6
b3a67000 b3aad000 r-xp /usr/lib/libcurl.so.4.3.0
b3abe000 b3adf000 r-xp /usr/lib/libexif.so.12.3.3
b3afa000 b3b0f000 r-xp /usr/lib/libtts.so
b3b20000 b3b28000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b38000 b3bfe000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c1e000 b3d16000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d35000 b3e03000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e1a000 b3e1c000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e2c000 b3e32000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e42000 b3e65000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e76000 b3e78000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e88000 b3e8a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e9b000 b3ea0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eb7000 b3eb9000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ec9000 b3ed0000 r-xp /usr/lib/libsensord-share.so
b3ee0000 b3ef8000 r-xp /usr/lib/libsensor.so.1.1.0
b3f09000 b3f0c000 r-xp /usr/lib/libXv.so.1.0.0
b3f1c000 b3f21000 r-xp /usr/lib/libutilX.so.1.1.0
b3f31000 b3f36000 r-xp /usr/lib/libappcore-common.so.1.1
b3f46000 b3f4d000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f60000 b3f64000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f75000 b4053000 r-xp /usr/lib/libCOREGL.so.4.0
b4073000 b4076000 r-xp /usr/lib/libuuid.so.1.3.0
b4086000 b409d000 r-xp /usr/lib/libblkid.so.1.1.0
b40ae000 b40b0000 r-xp /usr/lib/libXau.so.6.0.0
b40c0000 b4107000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4119000 b411f000 r-xp /usr/lib/libjson-c.so.2.0.1
b4130000 b4134000 r-xp /usr/lib/libogg.so.0.7.1
b4144000 b4166000 r-xp /usr/lib/libvorbis.so.0.4.3
b4176000 b425a000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4276000 b4279000 r-xp /usr/lib/libEGL.so.1.4
b428a000 b4290000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42a0000 b42a2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42b2000 b42bf000 r-xp /usr/lib/libGLESv2.so.2.0
b42d0000 b4332000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4347000 b435f000 r-xp /usr/lib/libmount.so.1.1.0
b4371000 b4385000 r-xp /usr/lib/libxcb.so.1.1.0
b4395000 b439c000 r-xp /lib/libcrypt-2.20-2014.11.so
b43d4000 b43d6000 r-xp /usr/lib/libiri.so
b43e6000 b43f1000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4402000 b4438000 r-xp /usr/lib/libpulse.so.0.16.2
b4449000 b448c000 r-xp /usr/lib/libsndfile.so.1.0.25
b44a1000 b44b6000 r-xp /lib/libexpat.so.1.5.2
b44c8000 b4586000 r-xp /usr/lib/libcairo.so.2.11200.14
b459a000 b45a2000 r-xp /usr/lib/libdrm.so.2.4.0
b45b2000 b45b5000 r-xp /usr/lib/libdri2.so.0.0.0
b45c5000 b4613000 r-xp /usr/lib/libssl.so.1.0.0
b4628000 b4634000 r-xp /usr/lib/libeeze.so.1.13.0
b4645000 b464e000 r-xp /usr/lib/libethumb.so.1.13.0
b465e000 b4661000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4671000 b4828000 r-xp /usr/lib/libcrypto.so.1.0.0
b5613000 b561c000 r-xp /usr/lib/libXi.so.6.1.0
b562c000 b562e000 r-xp /usr/lib/libXgesture.so.7.0.0
b563e000 b5642000 r-xp /usr/lib/libXtst.so.6.1.0
b5652000 b5658000 r-xp /usr/lib/libXrender.so.1.3.0
b5668000 b566e000 r-xp /usr/lib/libXrandr.so.2.2.0
b567e000 b5680000 r-xp /usr/lib/libXinerama.so.1.0.0
b5691000 b5694000 r-xp /usr/lib/libXfixes.so.3.1.0
b56a4000 b56af000 r-xp /usr/lib/libXext.so.6.4.0
b56bf000 b56c1000 r-xp /usr/lib/libXdamage.so.1.1.0
b56d1000 b56d3000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56e3000 b57c5000 r-xp /usr/lib/libX11.so.6.3.0
b57d9000 b57e0000 r-xp /usr/lib/libXcursor.so.1.0.2
b57f0000 b5808000 r-xp /usr/lib/libudev.so.1.6.0
b580a000 b580d000 r-xp /lib/libattr.so.1.1.0
b581d000 b583d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b583e000 b5843000 r-xp /usr/lib/libffi.so.6.0.2
b5854000 b586c000 r-xp /lib/libz.so.1.2.8
b587c000 b587e000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b588e000 b5963000 r-xp /usr/lib/libxml2.so.2.9.2
b5978000 b5a13000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a2f000 b5a32000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a42000 b5a5b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a6c000 b5a7d000 r-xp /lib/libresolv-2.20-2014.11.so
b5a91000 b5b0b000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b20000 b5b22000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b32000 b5b39000 r-xp /usr/lib/libembryo.so.1.13.0
b5b49000 b5b53000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b64000 b5b7c000 r-xp /usr/lib/libpng12.so.0.50.0
b5b8d000 b5bb0000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bd1000 b5be5000 r-xp /usr/lib/libector.so.1.13.0
b5bf6000 b5c0e000 r-xp /usr/lib/liblua-5.1.so
b5c1f000 b5c76000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c8a000 b5cb2000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cc3000 b5cd6000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ce7000 b5d21000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d32000 b5d40000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d50000 b5d58000 r-xp /usr/lib/libtbm.so.1.0.0
b5d68000 b5d75000 r-xp /usr/lib/libeio.so.1.13.0
b5d85000 b5d87000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d97000 b5d9c000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dac000 b5dc3000 r-xp /usr/lib/libefreet.so.1.13.0
b5dd5000 b5df5000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e05000 b5e25000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e27000 b5e2d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e3d000 b5e4e000 r-xp /usr/lib/libemotion.so.1.13.0
b5e5f000 b5e66000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e76000 b5e85000 r-xp /usr/lib/libeo.so.1.13.0
b5e96000 b5ea8000 r-xp /usr/lib/libecore_input.so.1.13.0
b5eb9000 b5ebe000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ece000 b5ee7000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5ef7000 b5f14000 r-xp /usr/lib/libeet.so.1.13.0
b5f2d000 b5f75000 r-xp /usr/lib/libeina.so.1.13.0
b5f86000 b5f96000 r-xp /usr/lib/libefl.so.1.13.0
b5fa7000 b608c000 r-xp /usr/lib/libicuuc.so.51.1
b60a9000 b61e9000 r-xp /usr/lib/libicui18n.so.51.1
b6200000 b6238000 r-xp /usr/lib/libecore_x.so.1.13.0
b624a000 b624d000 r-xp /lib/libcap.so.2.21
b625d000 b6286000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6297000 b629e000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62b0000 b62e7000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62f8000 b63e3000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63f6000 b646f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6481000 b6486000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6496000 b64a0000 r-xp /usr/lib/libvconf.so.0.2.45
b64b0000 b64b2000 r-xp /usr/lib/libvasum.so.0.3.1
b64c2000 b64c4000 r-xp /usr/lib/libttrace.so.1.1
b64d4000 b64d7000 r-xp /usr/lib/libiniparser.so.0
b64e7000 b650d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b651d000 b6522000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6533000 b654a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b655b000 b65c6000 r-xp /lib/libm-2.20-2014.11.so
b65d7000 b65dd000 r-xp /lib/librt-2.20-2014.11.so
b65ee000 b65fb000 r-xp /usr/lib/libunwind.so.8.0.1
b6631000 b6755000 r-xp /lib/libc-2.20-2014.11.so
b676a000 b6783000 r-xp /lib/libgcc_s-4.9.so.1
b6793000 b6875000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6886000 b68b0000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68c1000 b68fd000 r-xp /usr/lib/libsystemd.so.0.4.0
b68ff000 b6982000 r-xp /usr/lib/libedje.so.1.13.0
b6995000 b69b3000 r-xp /usr/lib/libecore.so.1.13.0
b69d3000 b6b5a000 r-xp /usr/lib/libevas.so.1.13.0
b6b8f000 b6ba3000 r-xp /lib/libpthread-2.20-2014.11.so
b6bb7000 b6deb000 r-xp /usr/lib/libelementary.so.1.13.0
b6e1a000 b6e1e000 r-xp /usr/lib/libsmack.so.1.0.0
b6e2e000 b6e35000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e45000 b6e47000 r-xp /usr/lib/libdlog.so.0.0.0
b6e57000 b6e5a000 r-xp /usr/lib/libbundle.so.0.1.22
b6e6a000 b6e6c000 r-xp /lib/libdl-2.20-2014.11.so
b6e7d000 b6e95000 r-xp /usr/lib/libaul.so.0.1.0
b6ea9000 b6eae000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ebf000 b6ecc000 r-xp /usr/lib/liblptcp.so
b6ede000 b6ee2000 r-xp /usr/lib/libsys-assert.so
b6ef3000 b6f13000 r-xp /lib/ld-2.20-2014.11.so
b6f24000 b6f29000 r-xp /usr/bin/launchpad-loader
b8a04000 b8de3000 rw-p [heap]
beb59000 beb7a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8892)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb665cb84) [/lib/libc.so.6] + 0x2bb84
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
: 2 (No such file or directory)[0;m
04-06 03:29:29.041+0900 E/PKGMGR  ( 8764): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[87640002]
04-06 03:29:29.192+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-06 03:29:29.192+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-06 03:29:29.192+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.192+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.192+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.192+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.192+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-06 03:29:29.202+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.202+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 03:29:29.202+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 03:29:29.202+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.202+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-06 03:29:29.202+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.202+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.342+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 03:29:29.342+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 03:29:29.352+0900 W/CERT_SVC_VCORE( 8769): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 03:29:29.432+0900 E/rpm-installer( 8769): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-06 03:29:29.432+0900 E/rpm-installer( 8769): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-06 03:29:29.492+0900 E/PKGMGR_PARSER( 8769): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-06 03:29:29.512+0900 I/PRIVACY-MANAGER-CLIENT( 8769): SocketClient.cpp: SocketClient(37) > Client created
04-06 03:29:29.512+0900 I/PRIVACY-MANAGER-CLIENT( 8769): SocketClient.cpp: connect(62) > Client connected
04-06 03:29:29.512+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-06 03:29:29.512+0900 I/PRIVACY-MANAGER-CLIENT( 8769): SocketClient.cpp: disconnect(72) > Client disconnected
04-06 03:29:29.512+0900 E/PKGMGR_CERT( 8769): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-06 03:29:29.522+0900 E/PKGMGR_CERT( 8769): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-06 03:29:29.522+0900 E/PKGMGR_CERT( 8769): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-06 03:29:29.562+0900 E/rpm-installer( 8769): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-06 03:29:29.562+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-06 03:29:29.562+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-06 03:29:29.562+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.562+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.562+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.562+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:29.562+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-06 03:29:29.572+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-06 03:29:29.572+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-06 03:29:29.572+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-06 03:29:31.083+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-06 03:29:31.234+0900 E/PKGMGR_SERVER( 8766): pkgmgr-server.c: sighandler(417) > child NORMAL exit [8769]
04-06 03:29:31.634+0900 E/PKGMGR_SERVER( 8766): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:29:31.634+0900 E/PKGMGR_SERVER( 8766): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:29:32.194+0900 I/APP_CORE(  842): appcore-efl.c: __do_app(514) > [APP 842] Event: MEM_FLUSH State: PAUSED
04-06 03:29:32.425+0900 E/PKGMGR  ( 8819): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-06 03:29:32.505+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: main(2414) > package manager server start
04-06 03:29:32.545+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-06 03:29:32.555+0900 E/PKGMGR_INFO( 8821): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-06 03:29:32.565+0900 E/rpm-installer( 8821): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-06 03:29:32.575+0900 E/PKGMGR_SERVER( 8821): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-06 03:29:32.575+0900 E/PKGMGR  ( 8819): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[88190002]
04-06 03:29:32.695+0900 E/PKGMGR_INSTALLER( 8824): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-06 03:29:32.695+0900 E/rpm-installer( 8824): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-06 03:29:32.705+0900 E/rpm-installer( 8824): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-06 03:29:32.705+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-06 03:29:32.705+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 03:29:32.705+0900 E/rpm-installer( 8824): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-06 03:29:32.705+0900 E/rpm-installer( 8824): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 03:29:32.765+0900 W/CERT_SVC_VCORE( 8824): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-06 03:29:32.815+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.815+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-06 03:29:32.815+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.815+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-06 03:29:32.815+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.815+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.825+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-06 03:29:32.825+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.825+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.825+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-06 03:29:32.825+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-06 03:29:32.825+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:32.825+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.035+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-06 03:29:33.045+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-06 03:29:33.045+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-06 03:29:33.045+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-06 03:29:33.045+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-06 03:29:33.045+0900 E/rpm-installer( 8824): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-06 03:29:33.045+0900 E/PKGMGR_PARSER( 8824): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-06 03:29:33.055+0900 E/PKGMGR_PARSER( 8824): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-06 03:29:33.085+0900 I/PRIVACY-MANAGER-CLIENT( 8824): SocketClient.cpp: SocketClient(37) > Client created
04-06 03:29:33.306+0900 E/PKGMGR_PARSER( 8824): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-06 03:29:33.316+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-06 03:29:33.326+0900 E/PKGMGR_CERT( 8824): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-06 03:29:33.336+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.336+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.336+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.336+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.336+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-06 03:29:33.336+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-06 03:29:33.336+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-06 03:29:33.346+0900 E/rpm-installer( 8824): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-06 03:29:33.376+0900 E/rpm-installer( 8824): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-06 03:29:33.376+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.376+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.376+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.376+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:33.376+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-06 03:29:33.376+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-06 03:29:33.376+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-06 03:29:34.637+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-06 03:29:35.187+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:35.187+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:35.187+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:35.187+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-06 03:29:35.187+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-06 03:29:35.187+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-06 03:29:35.207+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-06 03:29:35.207+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-06 03:29:35.207+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-06 03:29:35.207+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-06 03:29:35.227+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-06 03:29:35.237+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-06 03:29:35.237+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-06 03:29:35.237+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-06 03:29:35.237+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-06 03:29:35.237+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-06 03:29:35.237+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-06 03:29:35.237+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-06 03:29:35.247+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: sighandler(417) > child NORMAL exit [8824]
04-06 03:29:35.247+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 03:29:35.247+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 03:29:35.247+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-06 03:29:35.247+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-06 03:29:35.247+0900 I/Tizen::App( 1231): (840) > Enter.
04-06 03:29:35.257+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-06 03:29:35.257+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-06 03:29:35.257+0900 I/Tizen::App( 1231): (703) > Exit.
04-06 03:29:35.257+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-06 03:29:35.257+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-06 03:29:35.257+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (131) > Enter
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-06 03:29:35.267+0900 I/Tizen::App( 1231): (883) > Exit.
04-06 03:29:35.277+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-06 03:29:35.297+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-06 03:29:36.639+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:29:36.639+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:29:39.672+0900 W/AUL     ( 8879): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 03:29:39.672+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 03:29:39.682+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 03:29:39.692+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 03:29:39.692+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 03:29:39.692+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 8879
04-06 03:29:39.692+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 03:29:39.702+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 03:29:39.702+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 03:29:39.712+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 03:29:39.712+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 03:29:39.712+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 03:29:39.732+0900 I/abc     ( 8257): abc
04-06 03:29:39.732+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: ui_app_main(789) > app_efl_main
04-06 03:29:39.732+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 03:29:39.762+0900 E/TBM     ( 8257): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 03:29:39.812+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8257, appid: org.example.client
04-06 03:29:39.812+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 03:29:39.812+0900 W/AUL     ( 8879): launch.c: app_request_to_launchpad(425) > request cmd(0) result(8257)
04-06 03:29:40.022+0900 D/basicui ( 8257): successed to load edc file
04-06 03:29:40.052+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:40.052+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:40.072+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 03:29:40.072+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:40.072+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:40.092+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:29:40.112+0900 I/MY_LOG  ( 8257): change
04-06 03:29:40.152+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(514) > [APP 8257] Event: RESET State: CREATED
04-06 03:29:40.152+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 03:29:40.162+0900 E/EFL     ( 8257): edje<8257> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:29:40.162+0900 E/EFL     ( 8257): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:29:40.172+0900 E/EFL     ( 8257): edje<8257> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:29:40.172+0900 E/EFL     ( 8257): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:29:40.172+0900 E/EFL     ( 8257): edje<8257> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:29:40.172+0900 E/EFL     ( 8257): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:29:40.182+0900 W/APP_CORE( 8257): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7200002
04-06 03:29:40.182+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 03:29:40.282+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 03:29:40.282+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:29:40.282+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 03:29:40.292+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 03:29:40.292+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8257) status(3)
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:29:40.292+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(8257)
04-06 03:29:40.292+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8257, appid: org.example.client, status: fg
04-06 03:29:40.292+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(514) > [APP 8257] Event: RESUME State: CREATED
04-06 03:29:40.312+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 03:29:40.312+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 03:29:40.312+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 03:29:40.312+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 03:29:40.312+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(625) > [APP 8257] Initial Launching, call the resume_cb
04-06 03:29:40.312+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:29:40.663+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8257) status(0)
04-06 03:29:40.873+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2014
04-06 03:29:40.883+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 03:29:40.883+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 8257.
04-06 03:29:41.644+0900 I/UXT     ( 8892): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 03:29:42.995+0900 E/EFL     ( 8257): ecore_x<8257> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=214902361
04-06 03:29:42.995+0900 I/MY_LOG  ( 8257): Button pressed
04-06 03:29:43.105+0900 E/EFL     ( 8257): ecore_x<8257> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=214902471
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: vconf_get_bool(2729) > vconf_get_bool(8257) : db/ise/keysound error
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 03:29:43.165+0900 I/MY_LOG  ( 8257): Button unpressed
04-06 03:29:43.295+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8257 pgid = 8257
04-06 03:29:43.295+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(8257)
04-06 03:29:43.295+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:43.315+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 03:29:43.315+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:29:43.315+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:29:43.325+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 03:29:43.325+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 03:29:43.355+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 03:29:43.355+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 03:29:43.355+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 03:29:43.355+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 03:29:43.365+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[8257] terminate event is forwarded
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 8257, ]
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:29:43.365+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 03:29:43.365+0900 I/Tizen::App( 1231): (512) > Not registered pid(8257)
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 03:29:43.365+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:43.365+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 8257
04-06 03:29:43.365+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8257
04-06 03:29:43.365+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8257
04-06 03:29:43.375+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:29:43.375+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:29:43.375+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:29:43.375+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:43.385+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:29:43.415+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:43.415+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 8257.
04-06 03:29:43.415+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 03:29:43.425+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 03:29:43.425+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:43.455+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:43.465+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:29:43.475+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b450c8]
04-06 03:29:43.475+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 03:29:43.475+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b450c8
04-06 03:29:43.475+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 03:29:43.475+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:29:43.475+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 03:29:43.485+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 03:29:43.485+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 03:29:43.485+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 03:29:43.485+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 03:29:43.485+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 03:29:43.485+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:29:43.485+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:29:43.546+0900 W/CRASH_MANAGER( 8901): worker.c: worker_job(1199) > 0608257636c691491416983
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.509+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:29:47.509+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:30:00.492+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 03:30:00.492+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:30
04-06 03:30:00.492+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:30"
04-06 03:30:00.492+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:30"
04-06 03:30:00.492+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 03:30:00.492+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146640302 Time: <font_size=31> </font_size> <font_size=31> 오전 3:30</font_size></font>"
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.344+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:30:23.344+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:31:00.501+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 03:31:00.501+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:31
04-06 03:31:00.501+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:31"
04-06 03:31:00.501+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:31"
04-06 03:31:00.501+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 03:31:00.501+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146607984 Time: <font_size=31> </font_size> <font_size=31> 오전 3:31</font_size></font>"
04-06 03:31:18.959+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=214998322
04-06 03:31:19.039+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=214998399
04-06 03:31:19.039+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 03:31:19.039+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 03:31:19.039+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 858
04-06 03:31:19.049+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 03:31:19.049+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 03:31:19.049+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 03:31:19.049+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 03:31:19.049+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 03:31:19.069+0900 I/abc     ( 8892): abc
04-06 03:31:19.069+0900 I/CAPI_APPFW_APPLICATION( 8892): app_main.c: ui_app_main(789) > app_efl_main
04-06 03:31:19.069+0900 I/CAPI_APPFW_APPLICATION( 8892): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 03:31:19.089+0900 E/TBM     ( 8892): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 03:31:19.149+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8892, appid: org.example.client
04-06 03:31:19.149+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 03:31:19.159+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(425) > request cmd(1) result(8892)
04-06 03:31:19.349+0900 D/basicui ( 8892): successed to load edc file
04-06 03:31:19.379+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:31:19.379+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:31:19.399+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 03:31:19.399+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:31:19.399+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:31:19.409+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:31:19.439+0900 I/MY_LOG  ( 8892): change
04-06 03:31:19.479+0900 I/APP_CORE( 8892): appcore-efl.c: __do_app(514) > [APP 8892] Event: RESET State: CREATED
04-06 03:31:19.479+0900 I/CAPI_APPFW_APPLICATION( 8892): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 03:31:19.489+0900 E/EFL     ( 8892): edje<8892> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:31:19.489+0900 E/EFL     ( 8892): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:31:19.499+0900 E/EFL     ( 8892): edje<8892> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:31:19.499+0900 E/EFL     ( 8892): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:31:19.499+0900 E/EFL     ( 8892): edje<8892> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:31:19.499+0900 E/EFL     ( 8892): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:31:19.509+0900 W/APP_CORE( 8892): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-06 03:31:19.509+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 03:31:19.609+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 03:31:19.609+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:31:19.609+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 03:31:19.609+0900 I/APP_CORE( 8892): appcore-efl.c: __do_app(514) > [APP 8892] Event: RESUME State: CREATED
04-06 03:31:19.619+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 03:31:19.619+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 03:31:19.619+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 03:31:19.619+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8892) status(3)
04-06 03:31:19.619+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(8892)
04-06 03:31:19.619+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8892, appid: org.example.client, status: fg
04-06 03:31:19.629+0900 I/APP_CORE( 8892): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 03:31:19.629+0900 I/APP_CORE( 8892): appcore-efl.c: __do_app(625) > [APP 8892] Initial Launching, call the resume_cb
04-06 03:31:19.629+0900 I/CAPI_APPFW_APPLICATION( 8892): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:31:19.629+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 03:31:19.629+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 03:31:19.629+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 03:31:19.980+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8892) status(0)
04-06 03:31:20.210+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2020
04-06 03:31:20.210+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 03:31:20.210+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 8892.
04-06 03:31:21.001+0900 I/UXT     ( 8965): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 03:31:21.391+0900 E/EFL     ( 8892): ecore_x<8892> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=215000754
04-06 03:31:21.471+0900 E/EFL     ( 8892): ecore_x<8892> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=215000831
04-06 03:31:23.933+0900 E/EFL     ( 8892): ecore_x<8892> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=215003292
04-06 03:31:23.933+0900 I/MY_LOG  ( 8892): Button pressed
04-06 03:31:24.034+0900 E/EFL     ( 8892): ecore_x<8892> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=215003403
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf.c: vconf_get_bool(2729) > vconf_get_bool(8892) : db/ise/keysound error
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 03:31:24.094+0900 I/MY_LOG  ( 8892): Button unpressed
04-06 03:31:24.234+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:31:24.234+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8892 pgid = 8892
04-06 03:31:24.234+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(8892)
04-06 03:31:24.244+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 03:31:24.244+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:31:24.244+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:31:24.244+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 03:31:24.244+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 03:31:24.284+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 03:31:24.284+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 03:31:24.284+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 03:31:24.284+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 8892
04-06 03:31:24.284+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[8892] terminate event is forwarded
04-06 03:31:24.284+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:31:24.284+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 8892, ]
04-06 03:31:24.284+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:31:24.284+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 03:31:24.284+0900 I/Tizen::App( 1231): (512) > Not registered pid(8892)
04-06 03:31:24.284+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 03:31:24.284+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:31:24.284+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8892
04-06 03:31:24.284+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8892
04-06 03:31:24.294+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2024
04-06 03:31:24.294+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 03:31:24.304+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:31:24.304+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 8892.
04-06 03:31:24.314+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:31:24.314+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:31:24.314+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:31:24.314+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:31:24.344+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:31:24.344+0900 W/CRASH_MANAGER( 8972): worker.c: worker_job(1199) > 0608892636c69149141708
